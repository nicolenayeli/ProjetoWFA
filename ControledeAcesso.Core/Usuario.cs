
using ControledeAcesso.Core.ControleAcesso.Core;
using System.Data;
using System.Runtime.CompilerServices;

namespace ControledeAcesso.Core
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? TipoUsuario { get; set; }
        public string? Senha { get; set; }



        public Usuario() { }

        public Usuario(int id, string nome, string cpf, string tipoUsuaario, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuaario;
            Senha = senha;
        }

        public Usuario(string nome, string cpf, string senha)
        {
            Nome = nome;
            Senha = senha;
            Cpf = cpf;

        }

        public Usuario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void CadastrarUsuario()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert Usuario (Nome, Cpf, TipoUsuario, Senha) " +
                $"values ('{Nome}','{Cpf}','{TipoUsuario}',md5('{Senha}'))";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select last_insert_id()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static Usuario EfetuarLogin(string cpf, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Usuario where cpf = @cpf and senha = md5(@senha)";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);// campo id - int
                usuario.Nome = dr.GetString(1);// campo nome - varchar
                usuario.Cpf = dr.GetString(2);// campo email - varchar
             
            }
            return usuario;
        }

        public void Alterar() // altera só o nome
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set nome = '{Nome}' where id = {Id}";
            cmd.ExecuteNonQuery();
            
        }
    }
}