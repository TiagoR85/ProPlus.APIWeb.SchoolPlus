using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IDisciplina
    {
        public int DisciplinaID { get; set; }
        public string NomeDisciplina { get; set; }
        public int DadoEscolarID { get; set; }
        public IList<IProfessor> Professores { get; set; }
    }
}