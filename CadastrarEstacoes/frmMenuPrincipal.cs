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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            carregaComboEstacao();
            desabilitaCampos();
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
            cbbEstacao.Items.Clear();
            while (DR.Read())
            {
                cbbEstacao.Items.Add(DR.GetString(0));
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
                    txtCodigo.Text = DR.GetInt32(0).ToString();
                    txtNome.Text = DR.GetString(1);
                    txtLocalizacao.Text = DR.GetString(2);
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

        public void desabilitaCampos()
        {
            txtNome.Enabled = false;
            txtLocalizacao.Enabled = false;
            btnSalvar.Enabled = false;
        }

        public void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtLocalizacao.Enabled = true;
            btnSalvar.Enabled = true;
        }

        public void atualizarDados()
        {
            try
            {
                int cod_estacao = int.Parse(txtCodigo.Text);
                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = $"UPDATE tb_estacoes set nome = '{txtNome.Text}', localizacao = '{txtLocalizacao.Text}' WHERE codigo = {txtCodigo.Text}",
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };
                int res = comm.ExecuteNonQuery();

                if (res == 1)
                {
                    MessageBox.Show("Dados atualizado com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampos();
                    carregaComboEstacao();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar dados no banco!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao atualizar dados no banco!\n\n{e}");
            }
        }

        public void deletarEstacao()
        {
            DialogResult confirma = MessageBox.Show("Tem certeza que quer apagar esta estação?\nEsta operação não é reversível!", 
                "Mensagem do Sistema", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation);

            if (confirma == DialogResult.Yes)
            {
                int codigo = int.Parse(txtCodigo.Text);
                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = $"DELETE FROM tb_estacoes WHERE codigo = {codigo}",
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };

                int res = comm.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Estação deletada com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampos();
                    carregaComboEstacao();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar estação!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void limpaCampos()
        {
            txtCodigo.Clear();
            txtLocalizacao.Clear();
            txtNome.Clear();
            cbbEstacao.Text = "Selecione";
        }

        /*
                                     #####################
                                     ###### EVENTOS ######
                                     #####################
        */
        private void btnEstacao_Click(object sender, EventArgs e)
        {
            frmCadastrarEstacao abrir = new frmCadastrarEstacao();
            abrir.ShowDialog();
        }

        private void btnCaracteristica_Click(object sender, EventArgs e)
        {
            frmCadastrarCaracteristicas abrir = new frmCadastrarCaracteristicas();
            abrir.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbEstacao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbEstacao.SelectedItem.ToString() != "Selecione")
            {
                preencheDados(cbbEstacao.SelectedItem.ToString());
                Conexao.fecharConexao();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbbEstacao.Text == "Selecione")
            {
                MessageBox.Show("Selecione uma estação primeiro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            habilitaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            atualizarDados();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            limpaCampos();
            carregaComboEstacao();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (cbbEstacao.Text == "Selecione")
            {
                MessageBox.Show("Selecione uma estação primeiro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            deletarEstacao();
        }
    }
}
