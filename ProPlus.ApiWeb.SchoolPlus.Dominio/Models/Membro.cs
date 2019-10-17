using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Membro : IMembro
    {
        public IPessoa Usuario { get; set; }
        public IDadosVisual DadosVisual { get; set; }
        public int MembroID { get; set; }
    }
}
