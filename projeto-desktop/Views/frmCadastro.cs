using projeto_desktop.Models;
using projeto_desktop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_desktop
{
    public partial class frmCadastro : Form
    {
        private Usuario usuario = null;

        public frmCadastro()
        {
            InitializeComponent();
        }

        public frmCadastro(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (!Utils.temCamposVazio(this))
           
            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                   
                    Usuario usuario = new Usuario
                    {
                        nome = nometextBox.Text,
                        email = usuariotextBox.Text,
                        senha = "1234",
                        endereco = enderecotextBox.Text,
                      
                    };
                 
                    repository.adicionar(usuario);

                    
                    MessageBox.Show("Dados Salvos.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                else
                {
                   
                    this.usuario.nome = usuariotextBox.Text;
                    this.usuario.email = usuariotextBox.Text;
                    this.usuario.senha = "1234";
                    this.usuario.endereco = enderecotextBox.Text;
              
                    repository.editar(usuario);
                }
                this.Close();

               
            }
            else
            {   
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                new frmCadastro().ShowDialog();
            }
        }
        public static bool temCamposVazio(Form form)
        {

            foreach (Control c in form.Controls)
            {

                TextBox tbx = c as TextBox;

                if (tbx != null && tbx.Text.Trim().Length == 0)
                {

                    return true;
                }
            }

            return false;
        }


        private void frmCadastro_Load(object sender, EventArgs e)
        {
              if (usuario != null)
             {
             nometextBox.Text = usuario.nome;
             usuariotextBox.Text = usuario.email;

             enderecotextBox.Text = usuario.endereco;
            }


            if (frmLogin.idioma == 0){
                txtNome.Text = "Name";
                txtEndereco.Text = "Adress";
                txtNascimento.Text = "Birth";
                txtUsuario.Text = "User";
                txtSenha.Text = "Password";
                txtConfirmarSenha.Text = "confirm password";
            }
            else
            {
                txtNome.Text = "Nome";
                txtEndereco.Text = "Endereço";
                txtNascimento.Text = "Nascimento";
                txtUsuario.Text = "Usuario";
                txtSenha.Text = "Senha";
                txtConfirmarSenha.Text = "Confirmar Senha";

            }

        }

        private void frmCadastro_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
              MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel =  true;
            }
        }

        private void Inputs_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.BackColor = Color.Yellow ;

            }else {
               

            }

        }

        private void senhatextBox_TextChanged(object sender, EventArgs e)
        {
            if (senhatextBox.Text.Length >= 8)
            {

                string pattern = "[a-z]{ 1,}";
                if (Regex.IsMatch(senhatextBox.Text, pattern))
                {
                    pattern = "[A-Z]{ 1,}";
                    if (Regex.IsMatch(senhatextBox.Text, pattern))
                    {
                        pattern = "[0-9]{ 1,}";
                    }
                    if (Regex.IsMatch(senhatextBox.Text, pattern))
                    {
                        lblSenhaValida.Visible = true;
                    }
                }
                lblSenhaValida.Visible = false;
            }

            senhatextBox.PasswordChar = ('*');
        }

        private void confirmartextBox_TextChanged(object sender, EventArgs e)
        {
            confirmartextBox.PasswordChar = ('*');
        }
       
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (campoadmincheckBox.Checked)
            {
                new frmPrincipalAdmin().ShowDialog();
            }else {
                new frmPrincipalUsuario().ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            if (senhatextBox.Text.Equals(confirmartextBox.Text))
            {
                MessageBox.Show("Sua senha está correta.");
            }
            else 
            {
                MessageBox.Show("O campo senha e confirmar senha não são correspondentes.");
            }
        }


        private void Inputs_Leave(object sender, EventArgs e)
         {
         TextBox txt = sender as TextBox;
        if (txt == null)
         
         txt.BackColor = Color.White;

          if (txt.Text == "")
           {
         txt.Text = "Digite - " + txt.AccessibleName;
          }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
           
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox2.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(pictureBox2 != null)
            {
                pictureBox2.Image = null;
            }

        }

    }

}
