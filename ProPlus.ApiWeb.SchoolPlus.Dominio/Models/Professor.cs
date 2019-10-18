using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Professor : IProfessor
    {
        public IPessoa Usuario { get; set; }
        public int DisciplinaID { get; set; }
        public int ProfessorID { get; set; }
        public int InstituicaoID { get; set; }
    }
}
