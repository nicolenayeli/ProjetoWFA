namespace ProjetoWfa
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCpf = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 64);
            label1.Name = "label1";
            label1.Size = new Size(106, 36);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtCpf
            // 
            txtCpf.ForeColor = SystemColors.WindowFrame;
            txtCpf.Location = new Point(277, 150);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(290, 23);
            txtCpf.TabIndex = 3;
            txtCpf.Text = "CPF";
            // 
            // txtSenha
            // 
            txtSenha.ForeColor = SystemColors.WindowFrame;
            txtSenha.Location = new Point(277, 210);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(290, 23);
            txtSenha.TabIndex = 4;
            txtSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(321, 279);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(288, 382);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(163, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Clique aqui Para se Cadastrar.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 382);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 7;
            label4.Text = "Esqueceu a senha?";
            // 
            // button1
            // 
            button1.Location = new Point(424, 279);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtCpf);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCpf;
        private TextBox txtSenha;
        private Button btnEntrar;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button button1;
    }
}
