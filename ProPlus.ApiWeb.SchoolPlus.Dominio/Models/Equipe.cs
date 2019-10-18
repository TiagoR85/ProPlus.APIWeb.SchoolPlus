using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Equipe : IEquipe
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        [NotMapped]
        public IList<IMembro> Membros { get; set; }
        [NotMapped]
        public IDadosVisual Imagem { get; set; }
    }
}
