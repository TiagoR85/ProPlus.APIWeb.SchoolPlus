using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Disciplina : IDisciplina
    {
        public int DisciplinaID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NomeDisciplina { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IProfessor> Professores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
