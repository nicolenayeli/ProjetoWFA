using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControledeAcesso.Core
{
    class RegistrodeAcesso
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataHora { get; set; }

        public string? TipoOperacao { get; set; }


        public RegistrodeAcesso() { }
        public RegistrodeAcesso(int id, int usuarioId, DateTime dataHora, string tipoOperacao)
        {
            Id = id;
            UsuarioId = usuarioId;
            DataHora = dataHora;
            TipoOperacao = tipoOperacao;
        }


    }
}
