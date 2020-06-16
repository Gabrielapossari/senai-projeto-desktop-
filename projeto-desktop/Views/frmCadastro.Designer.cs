namespace projeto_desktop
{
    partial class frmCadastro
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
            this.txtNome = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.Label();
            this.enderecotextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.confirmartextBox = new System.Windows.Forms.TextBox();
            this.senhatextBox = new System.Windows.Forms.TextBox();
            this.usuariotextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.campoadmincheckBox = new System.Windows.Forms.CheckBox();
            this.lblSenhaValida = new System.Windows.Forms.Label();
            this.nometextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AccessibleName = "Nome";
            this.txtNome.AutoSize = true;
            this.txtNome.BackColor = System.Drawing.Color.Black;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.ForeColor = System.Drawing.Color.MintCream;
            this.txtNome.Location = new System.Drawing.Point(57, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(45, 17);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.AutoSize = true;
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.Black;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.MintCream;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(57, 263);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(126, 17);
            this.txtConfirmarSenha.TabIndex = 3;
            this.txtConfirmarSenha.Text = "Confirmar a Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.BackColor = System.Drawing.Color.Black;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.ForeColor = System.Drawing.Color.MintCream;
            this.txtSenha.Location = new System.Drawing.Point(57, 225);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(49, 17);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleName = "Usuario";
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.BackColor = System.Drawing.Color.Black;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsuario.ForeColor = System.Drawing.Color.MintCream;
            this.txtUsuario.Location = new System.Drawing.Point(57, 182);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(57, 17);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.Text = "Usuário";
            // 
            // txtNascimento
            // 
            this.txtNascimento.AutoSize = true;
            this.txtNascimento.BackColor = System.Drawing.Color.Black;
            this.txtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNascimento.ForeColor = System.Drawing.Color.MintCream;
            this.txtNascimento.Location = new System.Drawing.Point(57, 129);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(82, 17);
            this.txtNascimento.TabIndex = 6;
            this.txtNascimento.Text = "Nascimento";
            // 
            // txtEndereco
            // 
            this.txtEndereco.AccessibleName = "Endereco";
            this.txtEndereco.AutoSize = true;
            this.txtEndereco.BackColor = System.Drawing.Color.Black;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEndereco.ForeColor = System.Drawing.Color.MintCream;
            this.txtEndereco.Location = new System.Drawing.Point(57, 80);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(69, 17);
            this.txtEndereco.TabIndex = 7;
            this.txtEndereco.Text = "Endereço";
            // 
            // enderecotextBox
            // 
            this.enderecotextBox.AccessibleName = "Endereco";
            this.enderecotextBox.Location = new System.Drawing.Point(153, 77);
            this.enderecotextBox.Name = "enderecotextBox";
            this.enderecotextBox.Size = new System.Drawing.Size(184, 20);
            this.enderecotextBox.TabIndex = 9;
            this.enderecotextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Enter += new System.EventHandler(this.Inputs_Enter);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(365, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Enter += new System.EventHandler(this.Inputs_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Enter += new System.EventHandler(this.Inputs_Enter);
            // 
            // confirmartextBox
            // 
            this.confirmartextBox.Location = new System.Drawing.Point(205, 263);
            this.confirmartextBox.Name = "confirmartextBox";
            this.confirmartextBox.Size = new System.Drawing.Size(184, 20);
            this.confirmartextBox.TabIndex = 13;
            this.confirmartextBox.TextChanged += new System.EventHandler(this.confirmartextBox_TextChanged);
            this.confirmartextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            // 
            // senhatextBox
            // 
            this.senhatextBox.Location = new System.Drawing.Point(153, 222);
            this.senhatextBox.Name = "senhatextBox";
            this.senhatextBox.Size = new System.Drawing.Size(184, 20);
            this.senhatextBox.TabIndex = 14;
            this.senhatextBox.TextChanged += new System.EventHandler(this.senhatextBox_TextChanged);
            this.senhatextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            // 
            // usuariotextBox
            // 
            this.usuariotextBox.Location = new System.Drawing.Point(153, 179);
            this.usuariotextBox.Name = "usuariotextBox";
            this.usuariotextBox.Size = new System.Drawing.Size(184, 20);
            this.usuariotextBox.TabIndex = 15;
            this.usuariotextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cadastrar-se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(652, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // campoadmincheckBox
            // 
            this.campoadmincheckBox.AutoSize = true;
            this.campoadmincheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.campoadmincheckBox.ForeColor = System.Drawing.Color.Cornsilk;
            this.campoadmincheckBox.Location = new System.Drawing.Point(552, 263);
            this.campoadmincheckBox.Name = "campoadmincheckBox";
            this.campoadmincheckBox.Size = new System.Drawing.Size(78, 21);
            this.campoadmincheckBox.TabIndex = 19;
            this.campoadmincheckBox.Text = "É admin";
            this.campoadmincheckBox.UseVisualStyleBackColor = true;
            // 
            // lblSenhaValida
            // 
            this.lblSenhaValida.AutoSize = true;
            this.lblSenhaValida.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaValida.Location = new System.Drawing.Point(356, 225);
            this.lblSenhaValida.Name = "lblSenhaValida";
            this.lblSenhaValida.Size = new System.Drawing.Size(78, 13);
            this.lblSenhaValida.TabIndex = 20;
            this.lblSenhaValida.Text = "Senha Invalida";
            // 
            // nometextBox
            // 
            this.nometextBox.AccessibleName = "Nome";
            this.nometextBox.Location = new System.Drawing.Point(153, 33);
            this.nometextBox.Name = "nometextBox";
            this.nometextBox.Size = new System.Drawing.Size(184, 20);
            this.nometextBox.TabIndex = 8;
         
            this.nometextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(552, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 149);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(395, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Verificar senha";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSenhaValida);
            this.Controls.Add(this.campoadmincheckBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usuariotextBox);
            this.Controls.Add(this.senhatextBox);
            this.Controls.Add(this.confirmartextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.enderecotextBox);
            this.Controls.Add(this.nometextBox);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastro_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.Enter += new System.EventHandler(this.Inputs_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtConfirmarSenha;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtNascimento;
        private System.Windows.Forms.Label txtEndereco;
        private System.Windows.Forms.TextBox enderecotextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox confirmartextBox;
        private System.Windows.Forms.TextBox senhatextBox;
        private System.Windows.Forms.TextBox usuariotextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox campoadmincheckBox;
        private System.Windows.Forms.Label lblSenhaValida;
        private System.Windows.Forms.TextBox nometextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
    }
}