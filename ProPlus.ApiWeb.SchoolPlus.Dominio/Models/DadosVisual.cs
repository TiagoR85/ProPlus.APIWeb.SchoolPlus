using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class DadosVisual : IDadosVisual
    {
        public int VisualID { get; set; }
        public int DadosVisualID { get; set; }
        public string CaminhoRelativo { get; set; }
        public int UsuarioID { get; set; }
        public int ClaID { get; set; }
    }
}
