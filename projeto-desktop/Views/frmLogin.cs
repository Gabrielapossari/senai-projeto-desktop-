
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static int idioma;
        
            private void btnEntrar_Click(object sender, EventArgs e)
            {

            if (tbxUsuario.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }
            else
            {
                MessageBox.Show("Bem Vindo", "Entrada");
                new frmListaUsuario().ShowDialog();

            }

            }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            horariolabel.Text = DateTime.Now.ToString("HH:mm:ss:fff");

        }

        private void btnCadastre_Click(object sender, EventArgs e)
        {
            idioma = idiomacomboBox.SelectedIndex;
            new frmCadastro().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
              
                Application.Exit();
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void horariolabel_Click(object sender, EventArgs e)
        {
              timer1.Enabled = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

       
    }
}

