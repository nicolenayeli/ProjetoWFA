
using System.Data;
using System.Runtime.CompilerServices;

namespace ControledeAcesso.Core
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TipoUsuario { get; set; }
        public string Senha { get; set; }



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



        public string Inserir()
        {
           
        }

        public void Alterar() 
        {
            
        }

    }
}