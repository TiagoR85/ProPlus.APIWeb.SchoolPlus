using System.Collections.Generic;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IDisciplina
    {
        public int DisciplinaID { get; set; }
        public string NomeDisciplina { get; set; }
        public IList<IProfessor> Professores { get; set; }
    }
}