namespace AgendaDeContatos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.Registro = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCriarBanco = new System.Windows.Forms.Button();
            this.btnCriarTabela = new System.Windows.Forms.Button();
            this.btnExibirDados = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnIncluirDados = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnDeletarDados = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Location = new System.Drawing.Point(61, 24);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.RowHeadersWidth = 51;
            this.dgvTabela.RowTemplate.Height = 24;
            this.dgvTabela.Size = new System.Drawing.Size(709, 220);
            this.dgvTabela.TabIndex = 0;
            this.dgvTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellContentClick);
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.Location = new System.Drawing.Point(68, 270);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(66, 16);
            this.Registro.TabIndex = 1;
            this.Registro.Text = "Registro";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(68, 300);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(48, 16);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome";
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celular.Location = new System.Drawing.Point(68, 334);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(56, 16);
            this.Celular.TabIndex = 3;
            this.Celular.Text = "Celular";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(68, 362);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(51, 16);
            this.Email.TabIndex = 4;
            this.Email.Text = "E-mail";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 267);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(193, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 297);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(309, 22);
            this.txtNome.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(150, 331);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(193, 22);
            this.txtCelular.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 362);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // btnCriarBanco
            // 
            this.btnCriarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarBanco.Location = new System.Drawing.Point(154, 412);
            this.btnCriarBanco.Name = "btnCriarBanco";
            this.btnCriarBanco.Size = new System.Drawing.Size(109, 47);
            this.btnCriarBanco.TabIndex = 9;
            this.btnCriarBanco.Text = "Criar Banco";
            this.btnCriarBanco.UseVisualStyleBackColor = true;
            this.btnCriarBanco.Click += new System.EventHandler(this.btnCriarBanco_Click);
            // 
            // btnCriarTabela
            // 
            this.btnCriarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTabela.Location = new System.Drawing.Point(317, 412);
            this.btnCriarTabela.Name = "btnCriarTabela";
            this.btnCriarTabela.Size = new System.Drawing.Size(110, 47);
            this.btnCriarTabela.TabIndex = 10;
            this.btnCriarTabela.Text = "Criar Tabela";
            this.btnCriarTabela.UseVisualStyleBackColor = true;
            this.btnCriarTabela.Click += new System.EventHandler(this.btnCriarTabela_Click);
            // 
            // btnExibirDados
            // 
            this.btnExibirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirDados.Location = new System.Drawing.Point(473, 412);
            this.btnExibirDados.Name = "btnExibirDados";
            this.btnExibirDados.Size = new System.Drawing.Size(104, 47);
            this.btnExibirDados.TabIndex = 11;
            this.btnExibirDados.Text = "Exibir Dados";
            this.btnExibirDados.UseVisualStyleBackColor = true;
            this.btnExibirDados.Click += new System.EventHandler(this.btnExibirDados_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(627, 412);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(99, 47);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnIncluirDados
            // 
            this.btnIncluirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirDados.Location = new System.Drawing.Point(154, 465);
            this.btnIncluirDados.Name = "btnIncluirDados";
            this.btnIncluirDados.Size = new System.Drawing.Size(109, 46);
            this.btnIncluirDados.TabIndex = 13;
            this.btnIncluirDados.Text = "Incluir Dados";
            this.btnIncluirDados.UseVisualStyleBackColor = true;
            this.btnIncluirDados.Click += new System.EventHandler(this.btnIncluirDados_Click);
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDados.Location = new System.Drawing.Point(317, 465);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(110, 46);
            this.btnAlterarDados.TabIndex = 14;
            this.btnAlterarDados.Text = "Alterar Dados";
            this.btnAlterarDados.UseVisualStyleBackColor = true;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // btnDeletarDados
            // 
            this.btnDeletarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarDados.Location = new System.Drawing.Point(473, 465);
            this.btnDeletarDados.Name = "btnDeletarDados";
            this.btnDeletarDados.Size = new System.Drawing.Size(104, 46);
            this.btnDeletarDados.TabIndex = 15;
            this.btnDeletarDados.Text = "Deletar";
            this.btnDeletarDados.UseVisualStyleBackColor = true;
            this.btnDeletarDados.Click += new System.EventHandler(this.btnDeletarDados_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(627, 465);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(99, 46);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(838, 539);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnDeletarDados);
            this.Controls.Add(this.btnAlterarDados);
            this.Controls.Add(this.btnIncluirDados);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExibirDados);
            this.Controls.Add(this.btnCriarTabela);
            this.Controls.Add(this.btnCriarBanco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.dgvTabela);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Contatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCriarBanco;
        private System.Windows.Forms.Button btnCriarTabela;
        private System.Windows.Forms.Button btnExibirDados;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnIncluirDados;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnDeletarDados;
        private System.Windows.Forms.Button btnFechar;
    }
}

