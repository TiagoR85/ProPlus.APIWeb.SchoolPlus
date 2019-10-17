using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Avatar : IAvatar
    {
        public IPessoa Usuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IDadosVisual> Imagens { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
