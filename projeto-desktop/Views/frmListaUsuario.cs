using projeto_desktop.Models;
using projeto_desktop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_desktop
{
    public partial class frmListaUsuario : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        public frmListaUsuario()
        {
            InitializeComponent();
        }


        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaUsuario newMDIChild = new frmListaUsuario();
            
            newMDIChild.MdiParent = this;
          
            newMDIChild.Show();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            carregaLista();
        }
        private void alterarContador()
        {
            
            lblContador.Text = $"{dgvListaAluno.RowCount} itens de {repository.buscarTodos().Count}";
        }
        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvListaAluno.DataSource = null;
            dgvListaAluno.DataSource = repository.buscarTodos();
            alterarContador();
        }
        private void dgvListaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow linha = dgvListaAluno.Rows[e.RowIndex];
 
            string nome = linha.Cells[1].Value.ToString();
            string email = linha.Cells[2].Value.ToString();
            string userName = linha.Cells[3].Value.ToString();
            string senha = linha.Cells[4].Value.ToString();
            string telefone = linha.Cells[5].Value.ToString();
      
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
          
            Usuario usuario = new Usuario
            {
                codigo = codigo,
                nome = nome,
                email = email,
                senha = senha,
               

            };
          
            new frmCadastro(usuario).ShowDialog();

            carregaLista();
        }

        private void filtrotextBox_TextChanged(object sender, EventArgs e)
        {
            dgvListaAluno.DataSource = null;

         
            dgvListaAluno.DataSource = repository.buscarTodos().FindAll(x =>
                x.nome.ToUpper().Contains(filtrotextBox.Text.ToUpper()) ||
                x.email.ToUpper().Contains(filtrotextBox.Text.ToUpper()) 
               
            );

            alterarContador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmLogin().ShowDialog();
        }

        private void dgvListaAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                  , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DataGridViewRow linha = dgvListaAluno.Rows[e.RowIndex];

                int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

                repository.deletar(codigo);

                carregaLista();
            }
        }

 
    }
}
