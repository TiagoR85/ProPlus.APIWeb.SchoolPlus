using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Telefone : ITelefone
    {
        public int TelefoneId { get; set; }
        public Enums.TipoTelefone TipoTelefone { get; set; }
        public string NroTelefone { get; set; }
        public int InstituicaoID { get; set; }
        public int UsuarioID { get; set; }
    }
}
