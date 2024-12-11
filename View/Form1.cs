using AgendaDeContatos.Controller;
using AgendaDeContatos.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaDeContatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarBanco_Click(object sender, EventArgs e)
        {
            try 
            {
                ContatoController.CriarBancoSQLite();
                btnCriarBanco.Enabled = false;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro na criação do banco de dados: " + ex);
            }
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            try
            {
                ContatoController.CriarTabelaSQLite();
                btnCriarTabela.Enabled = false;
            }
            catch( SqlException ex) 
            {
                MessageBox.Show("Erro na criação da tabela: " + ex);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja encerra a aplicação?", "Encerrar aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void btnIncluirDados_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("Informe todos os campos do formulário corretamente!");
                return;
            }
            try
            {
                Contato cont = new Contato();
                cont.Id = Convert.ToInt32(txtId.Text);
                cont.Nome = txtNome.Text;
                cont.Celular = txtCelular.Text;
                cont.Email = txtEmail.Text;
                ContatoController.AddContato(cont);
                ExibirDados();
                LimpaDados();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private bool Valida() 
        {
            if(string.IsNullOrEmpty(txtId.Text) && string.IsNullOrEmpty(txtNome.Text) && string.IsNullOrEmpty(txtCelular.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                return false;
            }
            else
            {
                return true; 
            }
        }
        
        private void LimpaDados()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
        }

        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ContatoController.GetContatos();
                dgvTabela.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            
            }

        private void btnExibirDados_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) 
            {
                MessageBox.Show("Informe o registro do contato a ser localizado!");
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                int codigo = Convert.ToInt32(txtId.Text);
                dt = ContatoController.GetContato(codigo);
                dgvTabela.DataSource = dt;
                LimpaDados();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("Informe os dados do cliente a ser alterado!");
                return;
            }
            try
            {
                Contato cont = new Contato();
                cont.Id = Convert.ToInt32(txtId.Text);
                cont.Nome = txtNome.Text;
                cont.Celular = txtCelular.Text;
                cont.Email = txtEmail.Text;
                ContatoController.UpdateContato(cont);
                ExibirDados();
                LimpaDados();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTabela.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtCelular.Text = row.Cells["Celular"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnDeletarDados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Informe o registro do contato a ser excluido!");
            }
            try
            {
                int codigo = Convert.ToInt32(txtId.Text);
                ContatoController.DeleteContato(codigo);
                ExibirDados();
                LimpaDados();
            }
            catch
            {

            }
        }
    }
}

