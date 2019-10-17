using System.Collections.Generic;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IDadosGamefication
    {
        public int GameficationID { get; set; }
        public IList<IAvatar> Avatares { get; set; }
        public IList<IEquipe> Equipes { get; set; }
        public ICla Cla { get; set; }
        public IList<IPontuacao> Pontuacoes { get; set; }
        public IList<IAmigo> Amigos { get; set; }
    }
}