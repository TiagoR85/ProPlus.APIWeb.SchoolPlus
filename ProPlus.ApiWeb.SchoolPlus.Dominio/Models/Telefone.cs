using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Telefone : ITelefone
    {
        public int TelefoneId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Enums.TipoTelefone TipoTelefone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NroTelefone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
