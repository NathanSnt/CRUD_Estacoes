using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastrarEstacoes
{
    public partial class frmCadastrarCaracteristicas : Form
    {
        public frmCadastrarCaracteristicas()
        {
            InitializeComponent();
            carregaComboEstacao();
            carregaComboValores();
        }

        public MySqlDataReader select(string campo, string tabela, string where = "")
        {
            try
            {
                MySqlCommand comm;
                if (where == "")
                {
                    comm = new MySqlCommand
                    {
                        CommandText = $"SELECT {campo} FROM {tabela}",
                        CommandType = CommandType.Text,
                        Connection = Conexao.obterConexao()
                    };
                }
                else
                {
                    comm = new MySqlCommand
                    {
                        CommandText = $"SELECT {campo} FROM {tabela} where {where}",
                        CommandType = CommandType.Text,
                        Connection = Conexao.obterConexao()
                    };
                }
                Console.WriteLine(comm.CommandText);
                return comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro no select\n\n{e}\n\n");
                return null;
            }
        }

        public void carregaComboEstacao()
        {
            MySqlDataReader DR = select("nome", "tb_estacoes");

            while (DR.Read() )
            {
                cbbEstacao.Items.Add(DR.GetString(0) );
            }
            Conexao.fecharConexao();
        }

        public void carregaComboValores()
        {
            MySqlDataReader DR = select("estado", "tb_estados_operacionais");

            while (DR.Read())
            {
                cbbEstadoOperacional.Items.Add(DR.GetString(0));
            }
            Conexao.fecharConexao();
        }

        public void preencheDados(string nome_estacao)
        {
            try
            {
                MySqlDataReader DR = select("*", "tb_estacoes", $"nome LIKE '%{nome_estacao}%'");
                DR.Read();

                try
                {
                    lblCodigo.Text = DR.GetInt32(0).ToString();
                    lblNome.Text = DR.GetString(1);
                    lblLocalizacao.Text = DR.GetString(2);
                    carregaDataGrid();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao receber dados sobre a estação\n\n{e}");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Erro ao buscar dados sobre estação\n\n{e}");
            }
        }

        public void inserirCaracteristica()
        {
            MySqlDataReader DR = select("codigo", "tb_estados_operacionais", $"estado = '{cbbEstadoOperacional.SelectedItem}'");
            DR.Read();

            int cod_estado = DR.GetInt32(0);

            DR = select("codigo", "tb_estacoes", $"nome = '{cbbEstacao.SelectedItem}'");
            DR.Read();

            int cod_estacao = DR.GetInt32(0);

            // Verifica se já existe registo no banco
            DR = select("*", "tb_caracteristicas", $"tipo= '{cbbCaracteristica.Text}' AND cod_estacao = '{cod_estacao}'");
            DR.Read();
            if (DR.HasRows)
            {
                MessageBox.Show("Erro ao inserir valores.\nDado já existente no banco!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = $"INSERT INTO tb_caracteristicas (tipo, cod_estado, cod_estacao) VALUES (@tipo, @cod_estado, @cod_estacao)",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            comm.Parameters.Clear();
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = cbbCaracteristica.Text;
            comm.Parameters.Add("@cod_estado", MySqlDbType.Int32).Value = cod_estado;
            comm.Parameters.Add("@cod_estacao", MySqlDbType.Int32).Value = cod_estacao;

            Console.WriteLine(comm.CommandText);

            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Valores inseridos com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregaDataGrid();
            }
            else
            {
                MessageBox.Show("Erro ao inserir valores", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool checaCampos()
        {
            if (cbbEstacao.Text != "Selecione" 
                && cbbCaracteristica.Text != "Selecione"
                && cbbEstadoOperacional.Text != "Selecione")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
                return false;
            }
        }

        public void limparCampos()
        {
            cbbEstacao.Text = "Selecione";
            cbbCaracteristica.Text = "Selecione";
            cbbEstadoOperacional.Text = "Selecione";
            lblCodigo.Text = "";
            lblNome.Text = "";
            lblLocalizacao.Text = "";
        }

        public void carregaDataGrid()
        {
            dgvCaracteristicas.Rows.Clear();
            cbbCaracteristica.Text = "Selecione";
            cbbEstadoOperacional.Text = "Selecione";

            MySqlDataReader DR = select("*", "tb_caracteristicas", $"cod_estacao = {lblCodigo.Text}");
            while (DR.Read())
            {
                MySqlDataReader DR_estado = select("estado", "tb_estados_operacionais", $"codigo = '{DR.GetString(2)}'");
                DR_estado.Read();

                string estado = DR_estado.GetString(0);

                MySqlDataReader DR_estacao = select("nome", "tb_estacoes", $"codigo = '{DR.GetString(3)}'");
                DR_estacao.Read();

                string nome_estacao = DR_estacao.GetString(0);
                
                dgvCaracteristicas.Rows.Add(
                    DR.GetInt32(0),
                    DR.GetString(1),
                    estado,
                    nome_estacao
                );
            }
        }
        
        public void selecionaValoresNaCombo(string caracteristica, string estado_operacional)
        {
            cbbCaracteristica.SelectedIndex = cbbCaracteristica.Items.IndexOf(caracteristica);
            cbbEstadoOperacional.SelectedIndex = cbbEstadoOperacional.Items.IndexOf(estado_operacional);
        }

        public void atualizaCaracteristica()
        {
            MySqlDataReader DR = select("codigo", "tb_estados_operacionais", $"estado = '{cbbEstadoOperacional.SelectedItem}'");
            DR.Read();

            int cod_estado = DR.GetInt32(0);

            DR = select("codigo", "tb_estacoes", $"nome = '{cbbEstacao.SelectedItem}'");
            DR.Read();

            int cod_estacao = DR.GetInt32(0);

            DR = select("codigo", "tb_caracteristicas", $"tipo= '{cbbCaracteristica.Text}' AND cod_estacao = '{cod_estacao}'");
            DR.Read();

            if (!DR.HasRows)
            {
                MessageBox.Show("Erro ao atualizar valores.\nValores inexistentes no banco. Adicione antes de atualizar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = $"UPDATE tb_caracteristicas SET cod_estado = @cod_estado WHERE tipo = @tipo AND cod_estacao = @cod_estacao",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            comm.Parameters.Clear();
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = cbbCaracteristica.Text;
            comm.Parameters.Add("@cod_estado", MySqlDbType.Int32).Value = cod_estado;
            comm.Parameters.Add("@cod_estacao", MySqlDbType.Int32).Value = cod_estacao;

            Console.WriteLine(comm.CommandText);

            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Valores atualizados com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregaDataGrid();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar valores", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void deletaCaracteristica(bool todas = false)
        {
            MySqlDataReader DR = select("codigo", "tb_estacoes", $"nome = '{cbbEstacao.SelectedItem}'");
            DR.Read();
            int cod_estacao = DR.GetInt32(0);

            int cod_caracteristica = 0;
            if (!todas)
            {
                DR = select("codigo", "tb_caracteristicas", $"tipo= '{cbbCaracteristica.Text}' AND cod_estacao = '{cod_estacao}'");
                DR.Read();
                cod_caracteristica = DR.GetInt32(0);
            }

            string commString;

            if (todas)
            {
                DialogResult confirma = MessageBox.Show("Tem certeza que quer apagar TODOS esses registros?\nEssa operação não é reversível!",
                    "Mensagem do sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
                if (confirma == DialogResult.No)
                {
                    return;
                }

                commString = $"DELETE FROM tb_caracteristicas WHERE cod_estacao = {cod_estacao}";
            }
            else
            {
                DialogResult confirma = MessageBox.Show("Tem certeza que quer apagar esse registro?", 
                    "Mensagem do sistema", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
                if (confirma == DialogResult.No)
                {
                    return;
                }

                commString = $"DELETE FROM tb_caracteristicas WHERE codigo = {cod_caracteristica}";
            }

            MySqlCommand comm = new MySqlCommand
            {
                CommandText = commString,
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };

            Console.WriteLine(comm.CommandText);

            int res = comm.ExecuteNonQuery();
            if (res >= 1)
            {
                MessageBox.Show("Valores deletados com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregaDataGrid();
            }
            else
            {
                MessageBox.Show("Erro ao deletar valores", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
                                      #####################
                                      ###### EVENTOS ######
                                      #####################
         */

        private void cbbEstacao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbEstacao.SelectedItem.ToString() != "Selecione")
            {
                limparCampos();
                preencheDados(cbbEstacao.SelectedItem.ToString() );
                Conexao.fecharConexao();
            }
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            if (checaCampos())
            {
                inserirCaracteristica();
                Conexao.fecharConexao();
            }
        }

        private void dgvCaracteristicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string caracteristica = dgvCaracteristicas.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            string estado_operacional = dgvCaracteristicas.Rows[e.RowIndex].Cells["nome_estado"].Value.ToString();
            selecionaValoresNaCombo(caracteristica, estado_operacional);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizaCaracteristica();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            deletaCaracteristica();
        }

        private void btnRemoveTodos_Click(object sender, EventArgs e)
        {
            deletaCaracteristica(true);
        }
    }
}
