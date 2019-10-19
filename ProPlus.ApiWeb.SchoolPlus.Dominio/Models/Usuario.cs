using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Usuario : IPessoa
    {
        public Usuario()
        {
            Responsaveis = new List<IResponsavel>();
            Endereços = new List<IEndereco>();
            Emails = new List<IEmail>();
            Telefones = new List<ITelefone>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Enums.Sexo Sexualidade { get; set; }
        public int Altura_cm { get; set; }
        public int Peso_g { get; set; }
        [NotMapped]
        public List<IEndereco> Endereços { get; set; }
        [NotMapped]
        public List<IEmail> Emails { get; set; }
        [NotMapped]
        public List<ITelefone> Telefones { get; set; }
        [NotMapped]
        public List<IResponsavel> Responsaveis { get; set; }
        [NotMapped]
        public IDadosEscolares DadosEscolares { get; set; }
        public int DadosEscolaresID { get; set; }
        [NotMapped]
        public IDadosGamefication DadosGamefication { get; set; }
        public int DadosGameficationID { get; set; }
        public bool Ativo { get; set; }
        [NotMapped]
        public IDateTime RegistroTempo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataExclusao { get; set; }
        public DateTime UltimaModificacao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
