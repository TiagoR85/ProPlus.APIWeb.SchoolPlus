using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Equipe : IEquipe
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IMembro> Membros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDadosVisual Imagem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
