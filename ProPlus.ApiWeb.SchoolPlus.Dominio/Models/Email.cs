using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Email : IEmail
    {
        public int EmailId { get; set; }
        public string EnderecoEmail { get; set; }
        public int InstituicaoID { get; set; }
        public int UsuarioID { get; set; }
    }
}
