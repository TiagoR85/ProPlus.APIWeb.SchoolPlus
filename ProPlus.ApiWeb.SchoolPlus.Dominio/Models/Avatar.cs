using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Avatar : IAvatar
    {
        public int AvatarID { get; set; }
        public IPessoa Usuario { get; set; }
        public IList<IDadosVisual> Imagens { get; set; }
    }
}
