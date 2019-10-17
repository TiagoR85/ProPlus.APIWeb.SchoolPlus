using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class DadosEscolares : IDadosEscolares
    {
        public int EscolarID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Serie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NroSala { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IDisciplina> Disciplinas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Enums.Status ResultadoEscolar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
