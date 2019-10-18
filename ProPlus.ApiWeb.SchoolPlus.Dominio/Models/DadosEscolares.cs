using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class DadosEscolares : IDadosEscolares
    {
        public int DadosEscolaresID { get; set; }
        public string Serie { get; set; }
        public string NroSala { get; set; }
        [NotMapped]
        public IList<IDisciplina> Disciplinas { get; set; }
        public Enums.Status ResultadoEscolar { get; set; }
        public int UsuarioID { get; set; }
    }
}
