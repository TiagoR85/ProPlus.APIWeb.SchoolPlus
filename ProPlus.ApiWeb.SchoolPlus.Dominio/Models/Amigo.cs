using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Amigo : IAmigo
    {
        public int AmigoID { get; set; }
        public IPessoa Usuario { get; set; }
    }
}
