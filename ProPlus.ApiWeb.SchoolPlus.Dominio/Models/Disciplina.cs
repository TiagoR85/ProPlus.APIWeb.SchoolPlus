using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Disciplina : IDisciplina
    {
        public int DisciplinaID { get; set; }
        public string NomeDisciplina { get; set; }
        public int ProfessorID { get; set; }
        [NotMapped]
        public IList<IProfessor> Professores { get; set; }
        public int DadoEscolarID { get; set; }
    }
}
