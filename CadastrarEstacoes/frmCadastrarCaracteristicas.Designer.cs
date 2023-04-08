
namespace CadastrarEstacoes
{
    partial class frmCadastrarCaracteristicas
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
            this.gpbInfoEstacao = new System.Windows.Forms.GroupBox();
            this.lblCampoCodigo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCampoNome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCampoLocalizacao = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.cbbEstacao = new System.Windows.Forms.ComboBox();
            this.dgvCaracteristicas = new System.Windows.Forms.DataGridView();
            this.cbbCaracteristica = new System.Windows.Forms.ComboBox();
            this.cbbEstadoOperacional = new System.Windows.Forms.ComboBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.gpbCaracteristicas = new System.Windows.Forms.GroupBox();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnRemoveTodos = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_estacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbInfoEstacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).BeginInit();
            this.gpbCaracteristicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInfoEstacao
            // 
            this.gpbInfoEstacao.Controls.Add(this.cbbEstacao);
            this.gpbInfoEstacao.Controls.Add(this.lblSelecionar);
            this.gpbInfoEstacao.Controls.Add(this.lblLocalizacao);
            this.gpbInfoEstacao.Controls.Add(this.lblCampoLocalizacao);
            this.gpbInfoEstacao.Controls.Add(this.lblNome);
            this.gpbInfoEstacao.Controls.Add(this.lblCampoNome);
            this.gpbInfoEstacao.Controls.Add(this.lblCodigo);
            this.gpbInfoEstacao.Controls.Add(this.lblCampoCodigo);
            this.gpbInfoEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoEstacao.Location = new System.Drawing.Point(12, 12);
            this.gpbInfoEstacao.Name = "gpbInfoEstacao";
            this.gpbInfoEstacao.Size = new System.Drawing.Size(1053, 145);
            this.gpbInfoEstacao.TabIndex = 0;
            this.gpbInfoEstacao.TabStop = false;
            this.gpbInfoEstacao.Text = "Informações sobre a estação";
            // 
            // lblCampoCodigo
            // 
            this.lblCampoCodigo.AutoSize = true;
            this.lblCampoCodigo.Location = new System.Drawing.Point(497, 36);
            this.lblCampoCodigo.Name = "lblCampoCodigo";
            this.lblCampoCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCampoCodigo.TabIndex = 0;
            this.lblCampoCodigo.Text = "Código:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(573, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 16);
            this.lblCodigo.TabIndex = 1;
            // 
            // lblCampoNome
            // 
            this.lblCampoNome.AutoSize = true;
            this.lblCampoNome.Location = new System.Drawing.Point(6, 71);
            this.lblCampoNome.Name = "lblCampoNome";
            this.lblCampoNome.Size = new System.Drawing.Size(60, 20);
            this.lblCampoNome.TabIndex = 2;
            this.lblCampoNome.Text = "Nome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(72, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 16);
            this.lblNome.TabIndex = 3;
            // 
            // lblCampoLocalizacao
            // 
            this.lblCampoLocalizacao.AutoSize = true;
            this.lblCampoLocalizacao.Location = new System.Drawing.Point(6, 105);
            this.lblCampoLocalizacao.Name = "lblCampoLocalizacao";
            this.lblCampoLocalizacao.Size = new System.Drawing.Size(109, 20);
            this.lblCampoLocalizacao.TabIndex = 4;
            this.lblCampoLocalizacao.Text = "Localização:";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoEllipsis = true;
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacao.Location = new System.Drawing.Point(121, 105);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(0, 14);
            this.lblLocalizacao.TabIndex = 5;
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Location = new System.Drawing.Point(6, 36);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(201, 20);
            this.lblSelecionar.TabIndex = 6;
            this.lblSelecionar.Text = "Selecione uma estação:";
            // 
            // cbbEstacao
            // 
            this.cbbEstacao.FormattingEnabled = true;
            this.cbbEstacao.Location = new System.Drawing.Point(213, 33);
            this.cbbEstacao.Name = "cbbEstacao";
            this.cbbEstacao.Size = new System.Drawing.Size(230, 28);
            this.cbbEstacao.TabIndex = 7;
            this.cbbEstacao.Text = "Selecione";
            this.cbbEstacao.SelectedValueChanged += new System.EventHandler(this.cbbEstacao_SelectedValueChanged);
            // 
            // dgvCaracteristicas
            // 
            this.dgvCaracteristicas.AllowUserToAddRows = false;
            this.dgvCaracteristicas.AllowUserToDeleteRows = false;
            this.dgvCaracteristicas.AllowUserToResizeColumns = false;
            this.dgvCaracteristicas.AllowUserToResizeRows = false;
            this.dgvCaracteristicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.tipo,
            this.nome_estado,
            this.nome_estacao});
            this.dgvCaracteristicas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCaracteristicas.Location = new System.Drawing.Point(12, 163);
            this.dgvCaracteristicas.Name = "dgvCaracteristicas";
            this.dgvCaracteristicas.Size = new System.Drawing.Size(1053, 139);
            this.dgvCaracteristicas.TabIndex = 1;
            this.dgvCaracteristicas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaracteristicas_CellClick);
            // 
            // cbbCaracteristica
            // 
            this.cbbCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCaracteristica.FormattingEnabled = true;
            this.cbbCaracteristica.Items.AddRange(new object[] {
            "Banheiro",
            "Elevador",
            "Terminal Interurbano de Ônibus",
            "Terminal Urbano de Ônibus",
            "Transferência interna gratuita",
            "Bicicletário",
            "Banheiro Acessível",
            "Estação Acessível",
            "Rampa",
            "Transposição de plataformas",
            "Escadas rolantes",
            "Acesso elevador",
            "Lanchonete",
            "Empório",
            "Caixa eletrônico",
            "Calçados",
            "Telefone para surdos",
            "Piso Tátil",
            "Transferência",
            "Acessórios",
            "Farmácia",
            "Rota acessível",
            "Achados e perdidos"});
            this.cbbCaracteristica.Location = new System.Drawing.Point(257, 38);
            this.cbbCaracteristica.Name = "cbbCaracteristica";
            this.cbbCaracteristica.Size = new System.Drawing.Size(283, 28);
            this.cbbCaracteristica.TabIndex = 2;
            this.cbbCaracteristica.Text = "Selecione";
            // 
            // cbbEstadoOperacional
            // 
            this.cbbEstadoOperacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstadoOperacional.FormattingEnabled = true;
            this.cbbEstadoOperacional.Location = new System.Drawing.Point(273, 82);
            this.cbbEstadoOperacional.Name = "cbbEstadoOperacional";
            this.cbbEstadoOperacional.Size = new System.Drawing.Size(267, 28);
            this.cbbEstadoOperacional.TabIndex = 3;
            this.cbbEstadoOperacional.Text = "Selecione";
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(853, 315);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(156, 37);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcionar.Location = new System.Drawing.Point(666, 315);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(156, 37);
            this.btnAdcionar.TabIndex = 5;
            this.btnAdcionar.Text = "Adicionar";
            this.btnAdcionar.UseVisualStyleBackColor = true;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // gpbCaracteristicas
            // 
            this.gpbCaracteristicas.Controls.Add(this.lblEstado);
            this.gpbCaracteristicas.Controls.Add(this.lblCaracteristicas);
            this.gpbCaracteristicas.Controls.Add(this.cbbEstadoOperacional);
            this.gpbCaracteristicas.Controls.Add(this.cbbCaracteristica);
            this.gpbCaracteristicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCaracteristicas.Location = new System.Drawing.Point(12, 308);
            this.gpbCaracteristicas.Name = "gpbCaracteristicas";
            this.gpbCaracteristicas.Size = new System.Drawing.Size(576, 130);
            this.gpbCaracteristicas.TabIndex = 6;
            this.gpbCaracteristicas.TabStop = false;
            this.gpbCaracteristicas.Text = "Características";
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Location = new System.Drawing.Point(6, 41);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(245, 20);
            this.lblCaracteristicas.TabIndex = 6;
            this.lblCaracteristicas.Text = "Selecione uma característica:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(6, 90);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(261, 20);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Selecione o estado operacional";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(666, 358);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(156, 37);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnRemoveTodos
            // 
            this.btnRemoveTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTodos.Location = new System.Drawing.Point(853, 358);
            this.btnRemoveTodos.Name = "btnRemoveTodos";
            this.btnRemoveTodos.Size = new System.Drawing.Size(156, 37);
            this.btnRemoveTodos.TabIndex = 9;
            this.btnRemoveTodos.Text = "Remover todos";
            this.btnRemoveTodos.UseVisualStyleBackColor = true;
            this.btnRemoveTodos.Click += new System.EventHandler(this.btnRemoveTodos_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // nome_estado
            // 
            this.nome_estado.HeaderText = "Estado Operacional";
            this.nome_estado.Name = "nome_estado";
            // 
            // nome_estacao
            // 
            this.nome_estacao.HeaderText = "Estação";
            this.nome_estacao.Name = "nome_estacao";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(666, 401);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(343, 34);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar ao Menu Principal";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCadastrarCaracteristicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 447);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRemoveTodos);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.gpbCaracteristicas);
            this.Controls.Add(this.dgvCaracteristicas);
            this.Controls.Add(this.btnAdcionar);
            this.Controls.Add(this.gpbInfoEstacao);
            this.Controls.Add(this.btnRemover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarCaracteristicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Características da estação";
            this.gpbInfoEstacao.ResumeLayout(false);
            this.gpbInfoEstacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).EndInit();
            this.gpbCaracteristicas.ResumeLayout(false);
            this.gpbCaracteristicas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInfoEstacao;
        private System.Windows.Forms.ComboBox cbbEstacao;
        private System.Windows.Forms.Label lblSelecionar;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Label lblCampoLocalizacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCampoNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCampoCodigo;
        private System.Windows.Forms.DataGridView dgvCaracteristicas;
        private System.Windows.Forms.ComboBox cbbCaracteristica;
        private System.Windows.Forms.ComboBox cbbEstadoOperacional;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.GroupBox gpbCaracteristicas;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemoveTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_estacao;
        private System.Windows.Forms.Button btnVoltar;
    }
}