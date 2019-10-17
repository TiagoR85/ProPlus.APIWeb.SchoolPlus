using System.Collections.Generic;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IAvatar
    {
        public IPessoa Usuario { get; set; }
        public IList<IDadosVisual> Imagens { get; set; }
    }
}