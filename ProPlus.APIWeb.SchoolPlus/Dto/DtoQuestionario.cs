using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System.Collections.Generic;

namespace ProPlus.APIWeb.SchoolPlus.Dto
{
    public class DtoQuestionario
    {
        public int QuestionarioID { get; set; }
        public string Questao { get; set; }
        public string Cabecalho { get; set; }
        public int UsuarioID { get; set; }
        public int ProfessorID { get; set; }
        public IDisciplina Disciplina { get; set; }
        public IEnumerable<IResposta> RespostasPossiveis { get; set; }
        public int RespostaCorretaID { get; set; }
    }
}
