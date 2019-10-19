using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Resposta : IResposta
    {
        public int RespostaID { get; set; }
        public int RespostaCorreta { get; set; }
        
        [NotMapped]
        public IEnumerable<IResposta> RespostasPossiveis { get; set; }
    }
}
