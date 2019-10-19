using System;
using System.Collections.Generic;
using System.Text;
using static ProPlus.ApiWeb.SchoolPlus.Dominio.Enums;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Sexo Sexualidade { get; set; }
        public int Altura_cm { get; set; }
        public int Peso_g { get; set; }
        public List<IEndereco> Endereços { get; set; }
        public List<IEmail> Emails { get; set; }
        public List<ITelefone> Telefones { get; set; }
        public List<IResponsavel> Responsaveis { get; set; }
        public IDadosEscolares DadosEscolares { get; set; }
        public IDadosGamefication DadosGamefication { get; set; }
        public bool Ativo { get; set; }
        public IDateTime RegistroTempo { get; set; }
    }
}
