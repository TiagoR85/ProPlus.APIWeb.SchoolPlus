using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Municipio : IMunicipio
    {
        public int MunicipioId { get; set; }
        public string CodMunicipio { get; set; }
        public string Nome { get; set; }
    }
}
