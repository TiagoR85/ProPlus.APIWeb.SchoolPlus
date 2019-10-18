using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IEquipe
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public IList<IMembro> Membros { get; set; }
        public IDadosVisual Imagem { get; set; }
    }
}