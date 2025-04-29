using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Core
{
    // Entidade usuário
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TipoUsuario { get; set; }
        public string Senha { get; set; }
    }

    // Registro de entrada/Saída

    public class RegistroAcesso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoOperacao { get; set; } //Entrada ou Saída

    }


    //Serviço de autenticação
    public class Autenticador
    {
        public bool ValidarLogin(string cpf, string senha)
        {
            //Simulação Verificada
        }
    }

}
