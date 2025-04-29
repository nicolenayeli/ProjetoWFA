namespace ProjetoWfa
{
    partial class RegistrodeAcesso
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Tipooperacaocln = new DataGridViewTextBoxColumn();
            Usuariocln = new DataGridViewTextBoxColumn();
            DataHoracln = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 60);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro De Acesso";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tipooperacaocln, Usuariocln, DataHoracln });
            dataGridView1.Location = new Point(248, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(302, 225);
            dataGridView1.TabIndex = 1;
            dataGridView1.TabStop = false;
            // 
            // Tipooperacaocln
            // 
            Tipooperacaocln.HeaderText = "Tipo Operação";
            Tipooperacaocln.Name = "Tipooperacaocln";
            // 
            // Usuariocln
            // 
            Usuariocln.HeaderText = "Usuario";
            Usuariocln.Name = "Usuariocln";
            // 
            // DataHoracln
            // 
            DataHoracln.HeaderText = "Data e Hora";
            DataHoracln.Name = "DataHoracln";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 117);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuario ID";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(415, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // RegistrodeAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "RegistrodeAcesso";
            Text = "RegistrodeAcesso";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Tipooperacaocln;
        private DataGridViewTextBoxColumn Usuariocln;
        private DataGridViewTextBoxColumn DataHoracln;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}