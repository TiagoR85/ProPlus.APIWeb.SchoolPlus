using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class DadosGamefication : IDadosGamefication
    {
        public int GameficationID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IAvatar> Avatares { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IEquipe> Equipes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICla Cla { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IPontuacao> Pontuacoes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IAmigo> Amigos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
