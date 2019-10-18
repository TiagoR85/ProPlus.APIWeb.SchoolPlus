using System.Collections.Generic;
using static ProPlus.ApiWeb.SchoolPlus.Dominio.Enums;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IDadosEscolares
    {
        public int UsuarioID { get; set; }
        public int DadosEscolaresID { get; set; }
        public string Serie { get; set; }
        public string NroSala { get; set; }
        public IList<IDisciplina> Disciplinas { get; set; }
        public Status ResultadoEscolar { get; set; }
    }
}