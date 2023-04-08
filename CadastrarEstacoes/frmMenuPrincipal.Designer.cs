
namespace CadastrarEstacoes
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEstacao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCaracteristica = new System.Windows.Forms.Button();
            this.gpbPesquisaEstacao = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbbEstacao = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpbPesquisaEstacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEstacao
            // 
            this.btnEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacao.Location = new System.Drawing.Point(12, 12);
            this.btnEstacao.Name = "btnEstacao";
            this.btnEstacao.Size = new System.Drawing.Size(217, 44);
            this.btnEstacao.TabIndex = 0;
            this.btnEstacao.Text = "Cadastrar Estação";
            this.btnEstacao.UseVisualStyleBackColor = true;
            this.btnEstacao.Click += new System.EventHandler(this.btnEstacao_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(571, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(216, 44);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCaracteristica
            // 
            this.btnCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaracteristica.Location = new System.Drawing.Point(293, 12);
            this.btnCaracteristica.Name = "btnCaracteristica";
            this.btnCaracteristica.Size = new System.Drawing.Size(217, 44);
            this.btnCaracteristica.TabIndex = 2;
            this.btnCaracteristica.Text = "Características";
            this.btnCaracteristica.UseVisualStyleBackColor = true;
            this.btnCaracteristica.Click += new System.EventHandler(this.btnCaracteristica_Click);
            // 
            // gpbPesquisaEstacao
            // 
            this.gpbPesquisaEstacao.Controls.Add(this.btnAtualizar);
            this.gpbPesquisaEstacao.Controls.Add(this.btnSalvar);
            this.gpbPesquisaEstacao.Controls.Add(this.btnDeletar);
            this.gpbPesquisaEstacao.Controls.Add(this.lblLocalizacao);
            this.gpbPesquisaEstacao.Controls.Add(this.lblNome);
            this.gpbPesquisaEstacao.Controls.Add(this.lblCodigo);
            this.gpbPesquisaEstacao.Controls.Add(this.txtLocalizacao);
            this.gpbPesquisaEstacao.Controls.Add(this.txtNome);
            this.gpbPesquisaEstacao.Controls.Add(this.txtCodigo);
            this.gpbPesquisaEstacao.Controls.Add(this.cbbEstacao);
            this.gpbPesquisaEstacao.Controls.Add(this.btnEditar);
            this.gpbPesquisaEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisaEstacao.Location = new System.Drawing.Point(12, 62);
            this.gpbPesquisaEstacao.Name = "gpbPesquisaEstacao";
            this.gpbPesquisaEstacao.Size = new System.Drawing.Size(775, 308);
            this.gpbPesquisaEstacao.TabIndex = 3;
            this.gpbPesquisaEstacao.TabStop = false;
            this.gpbPesquisaEstacao.Text = "Pesquisar Estação";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(504, 42);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(108, 26);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(600, 247);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 43);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(600, 182);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(113, 43);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(22, 234);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(99, 18);
            this.lblLocalizacao.TabIndex = 8;
            this.lblLocalizacao.Text = "Localizacao";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 149);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 100);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 18);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLocalizacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLocalizacao.Location = new System.Drawing.Point(127, 194);
            this.txtLocalizacao.Multiline = true;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(371, 102);
            this.txtLocalizacao.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(81, 149);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(417, 24);
            this.txtNome.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigo.Location = new System.Drawing.Point(90, 100);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(408, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // cbbEstacao
            // 
            this.cbbEstacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbbEstacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbEstacao.FormattingEnabled = true;
            this.cbbEstacao.Location = new System.Drawing.Point(25, 42);
            this.cbbEstacao.Name = "cbbEstacao";
            this.cbbEstacao.Size = new System.Drawing.Size(473, 26);
            this.cbbEstacao.TabIndex = 2;
            this.cbbEstacao.Text = "Selecione";
            this.cbbEstacao.SelectedValueChanged += new System.EventHandler(this.cbbEstacao_SelectedValueChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(600, 123);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 44);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 382);
            this.Controls.Add(this.gpbPesquisaEstacao);
            this.Controls.Add(this.btnCaracteristica);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEstacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.gpbPesquisaEstacao.ResumeLayout(false);
            this.gpbPesquisaEstacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCaracteristica;
        private System.Windows.Forms.GroupBox gpbPesquisaEstacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbbEstacao;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}