using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class DadosGamefication : IDadosGamefication
    {
        [Key]
        public int GameficationID { get; set; }
        public int ClaID { get; set; }
        [NotMapped]
        public IList<IAvatar> Avatares { get; set; }
        [NotMapped]
        public IList<IEquipe> Equipes { get; set; }
        [NotMapped]
        public ICla Cla { get; set; }
        [NotMapped]
        public IList<IPontuacao> Pontuacoes { get; set; }
        [NotMapped]
        public IList<IAmigo> Amigos { get; set; }
        public int UsuarioID { get; set; }
    }
}
