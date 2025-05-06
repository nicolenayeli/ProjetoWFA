using ControledeAcesso.Core;


namespace ProjetoWfa
{
    public partial class Login : Form
    {
        private bool logado = false;
        public Login()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (txtCpf.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtCpf.Text, txtSenha.Text);
                if (usuario.Id > 0)
                {
                    logado = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Cpf ou senha incorretos ou inexistente!", "Login");
                }
            }
            else
            {
                MessageBox.Show("Os campos email e senha são obrigatórios");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }
    }
}
