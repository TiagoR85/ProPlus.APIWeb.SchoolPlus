using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Questionario : IQuestionario
    {
        public int QuestionarioID { get; set; }
        public string Questao { get; set; }
        public string Cabecalho { get; set; }
        public int UsuarioID { get; set; }
        public int ProfessorID { get; set; }
        [NotMapped]
        public IDisciplina Disciplina { get; set; }
        [NotMapped]
        public IEnumerable<IResposta> RespostasPossiveis { get; set; }
        public int RespostaCorretaID { get; set; }
    }
}
