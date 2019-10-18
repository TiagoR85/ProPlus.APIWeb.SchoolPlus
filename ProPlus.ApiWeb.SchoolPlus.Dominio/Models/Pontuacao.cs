using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Pontuacao : IPontuacao
    {
        public int PontuacaoID { get; set; }
        public int UsuarioID { get; set; }
        public string NomeJogo { get; set; }
    }
}
