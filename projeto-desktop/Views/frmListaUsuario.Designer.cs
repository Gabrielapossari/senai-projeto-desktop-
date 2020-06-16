namespace projeto_desktop
{
    partial class frmListaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.filtrotextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvListaAluno = new System.Windows.Forms.DataGridView();
            this.lblContador = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro:";
            // 
            // filtrotextBox
            // 
            this.filtrotextBox.Location = new System.Drawing.Point(50, 6);
            this.filtrotextBox.Name = "filtrotextBox";
            this.filtrotextBox.Size = new System.Drawing.Size(180, 20);
            this.filtrotextBox.TabIndex = 1;
            this.filtrotextBox.TextChanged += new System.EventHandler(this.filtrotextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvListaAluno
            // 
            this.dgvListaAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAluno.Location = new System.Drawing.Point(15, 44);
            this.dgvListaAluno.Name = "dgvListaAluno";
            this.dgvListaAluno.Size = new System.Drawing.Size(730, 232);
            this.dgvListaAluno.TabIndex = 0;
            this.dgvListaAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAluno_CellContentClick);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(418, 406);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(35, 13);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.dgvListaAluno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filtrotextBox);
            this.Controls.Add(this.label1);
            this.Name = "frmListaUsuario";
            this.Text = "frmListaUsuario";
            this.Load += new System.EventHandler(this.frmListaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtrotextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvListaAluno;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button button2;
    }
}