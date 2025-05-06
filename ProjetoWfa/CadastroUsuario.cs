using ControledeAcesso.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWfa
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Usuario usuario = new(txtNome.Text, txtCpf.Text, txtSenha.Text);
            usuario.CadastrarUsuario();
            txtId.Text = usuario.Id.ToString();
            MessageBox.Show($"Usuário {usuario.Nome} gravado com sucesso com o ID {usuario.Id}");
         



        }
    }
}
