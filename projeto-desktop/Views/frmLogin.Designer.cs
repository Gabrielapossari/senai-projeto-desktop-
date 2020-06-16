namespace projeto_desktop
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.Usuario = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCadastre = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idiomacomboBox = new System.Windows.Forms.ComboBox();
            this.horariolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.Usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Usuario.Location = new System.Drawing.Point(357, 22);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(64, 20);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(287, 59);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(194, 20);
            this.tbxUsuario.TabIndex = 1;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.senha.ForeColor = System.Drawing.Color.Cornsilk;
            this.senha.Location = new System.Drawing.Point(357, 107);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(56, 20);
            this.senha.TabIndex = 2;
            this.senha.Text = "Senha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(283, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idioma";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(126, 312);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadastre
            // 
            this.btnCadastre.Location = new System.Drawing.Point(558, 312);
            this.btnCadastre.Name = "btnCadastre";
            this.btnCadastre.Size = new System.Drawing.Size(94, 23);
            this.btnCadastre.TabIndex = 7;
            this.btnCadastre.Text = "Novo Usuario";
            this.btnCadastre.UseVisualStyleBackColor = true;
            this.btnCadastre.Click += new System.EventHandler(this.btnCadastre_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // idiomacomboBox
            // 
            this.idiomacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idiomacomboBox.FormattingEnabled = true;
            this.idiomacomboBox.Items.AddRange(new object[] {
            "Ingles",
            "Portugues"});
            this.idiomacomboBox.Location = new System.Drawing.Point(287, 242);
            this.idiomacomboBox.Name = "idiomacomboBox";
            this.idiomacomboBox.Size = new System.Drawing.Size(121, 21);
            this.idiomacomboBox.TabIndex = 11;
            // 
            // horariolabel
            // 
            this.horariolabel.AutoSize = true;
            this.horariolabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.horariolabel.Location = new System.Drawing.Point(699, 29);
            this.horariolabel.Name = "horariolabel";
            this.horariolabel.Size = new System.Drawing.Size(41, 13);
            this.horariolabel.TabIndex = 12;
            this.horariolabel.Text = "Horario";
            this.horariolabel.Click += new System.EventHandler(this.horariolabel_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.horariolabel);
            this.Controls.Add(this.idiomacomboBox);
            this.Controls.Add(this.btnCadastre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.Usuario);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCadastre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox idiomacomboBox;
        private System.Windows.Forms.Label horariolabel;
    }
}

