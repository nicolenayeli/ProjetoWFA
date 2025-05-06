namespace ProjetoWfa
{
    partial class CadastroUsuario
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
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSenha = new TextBox();
            bntCadastrar = new Button();
            bntCancelar = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            txtCpf = new TextBox();
            label5 = new Label();
            txtId = new TextBox();
            txtTipoUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(241, 73);
            label2.Name = "label2";
            label2.Size = new Size(230, 24);
            label2.TabIndex = 1;
            label2.Text = "Cadastro de Usuario";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtNome.Location = new Point(273, 142);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(241, 20);
            txtNome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 142);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 185);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 6;
            label3.Text = "Cpf";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 260);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 9;
            label6.Text = "Tipo de Usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(654, 83);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "Foto";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 221);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 15;
            label8.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtSenha.Location = new Point(280, 221);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(193, 20);
            txtSenha.TabIndex = 14;
            // 
            // bntCadastrar
            // 
            bntCadastrar.Location = new Point(213, 330);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(127, 29);
            bntCadastrar.TabIndex = 16;
            bntCadastrar.Text = "Cadastrar";
            bntCadastrar.UseVisualStyleBackColor = true;
            bntCadastrar.Click += button1_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(377, 330);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(127, 29);
            bntCancelar.TabIndex = 17;
            bntCancelar.Text = "Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            bntCancelar.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Location = new Point(584, 381);
            button3.Name = "button3";
            button3.Size = new Size(80, 29);
            button3.TabIndex = 18;
            button3.Text = "Buscar ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Location = new Point(676, 381);
            button4.Name = "button4";
            button4.Size = new Size(97, 29);
            button4.TabIndex = 19;
            button4.Text = "Remover Foto";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ControledeAcesso.UI.Properties.Resources.Captura_de_tela_2025_05_06_110537;
            pictureBox1.Location = new Point(542, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 246);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(250, 180);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 188);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 8;
            label5.Text = "ID";
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtId.Location = new Point(387, 186);
            txtId.Name = "txtId";
            txtId.Size = new Size(48, 20);
            txtId.TabIndex = 3;
            // 
            // txtTipoUsuario
            // 
            txtTipoUsuario.Location = new Point(335, 247);
            txtTipoUsuario.Name = "txtTipoUsuario";
            txtTipoUsuario.Size = new Size(100, 23);
            txtTipoUsuario.TabIndex = 22;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTipoUsuario);
            Controls.Add(txtCpf);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(bntCancelar);
            Controls.Add(bntCadastrar);
            Controls.Add(label8);
            Controls.Add(txtSenha);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Name = "CadastroUsuario";
            Text = "CadastroUsuario";
            Load += CadastroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSenha;
        private Button bntCadastrar;
        private Button bntCancelar;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private TextBox txtCpf;
        private Label label5;
        private TextBox txtId;
        private TextBox txtTipoUsuario;
    }
}