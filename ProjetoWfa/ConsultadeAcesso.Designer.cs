namespace ProjetoWfa
{
    partial class ConsultadeAcesso
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            domainUpDown1 = new DomainUpDown();
            entradacln = new DataGridViewTextBoxColumn();
            saidacln = new DataGridViewTextBoxColumn();
            nomecln = new DataGridViewTextBoxColumn();
            datacln = new DataGridViewTextBoxColumn();
            tipooperacaocln = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 22);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 0;
            label1.Text = "Consultar Acesso";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { entradacln, saidacln, nomecln, datacln, tipooperacaocln });
            dataGridView1.Location = new Point(160, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 212);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 76);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 120);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 158);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 4;
            label4.Text = "Tipo de Operação";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(304, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(353, 156);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 10;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // entradacln
            // 
            entradacln.HeaderText = "Entrada";
            entradacln.Name = "entradacln";
            // 
            // saidacln
            // 
            saidacln.HeaderText = "Saida";
            saidacln.Name = "saidacln";
            // 
            // nomecln
            // 
            nomecln.HeaderText = "Nome";
            nomecln.Name = "nomecln";
            // 
            // datacln
            // 
            datacln.HeaderText = "Data";
            datacln.Name = "datacln";
            // 
            // tipooperacaocln
            // 
            tipooperacaocln.HeaderText = "Tipo_Opc";
            tipooperacaocln.Name = "tipooperacaocln";
            // 
            // ConsultadeAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(domainUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ConsultadeAcesso";
            Text = "ConsultadeAcesso";
            Load += ConsultadeAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DomainUpDown domainUpDown1;
        private DataGridViewTextBoxColumn entradacln;
        private DataGridViewTextBoxColumn saidacln;
        private DataGridViewTextBoxColumn nomecln;
        private DataGridViewTextBoxColumn datacln;
        private DataGridViewTextBoxColumn tipooperacaocln;
    }
}