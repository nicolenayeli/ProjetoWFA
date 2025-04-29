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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            domainUpDown1 = new DomainUpDown();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 72);
            label2.Name = "label2";
            label2.Size = new Size(230, 24);
            label2.TabIndex = 1;
            label2.Text = "Cadastro de Usuario";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox1.Location = new Point(306, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 20);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox2.Location = new Point(415, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(48, 20);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 147);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 190);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 6;
            label3.Text = "Cpf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 193);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 7;
            label4.Text = "___-___-___ -_";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 193);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 8;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 265);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 9;
            label6.Text = "Tipo de Usuario";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(351, 263);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 11;
            domainUpDown1.Text = "Comum";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(667, 99);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "Foto";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(255, 226);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 15;
            label8.Text = "Senha";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox3.Location = new Point(313, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 20);
            textBox3.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(237, 340);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 16;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(401, 340);
            button2.Name = "button2";
            button2.Size = new Size(127, 29);
            button2.TabIndex = 17;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Location = new Point(592, 306);
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
            button4.Location = new Point(684, 306);
            button4.Name = "button4";
            button4.Size = new Size(97, 29);
            button4.TabIndex = 19;
            button4.Text = "Remover Foto";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(613, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 174);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(domainUpDown1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DomainUpDown domainUpDown1;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
    }
}