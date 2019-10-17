using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Instituicao : IInstituicao
    {
        public int InstituicaoID { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public IList<IProfessor> Professores { get; set; }
        public IList<IEndereco> Enderecos { get; set; }
        public IList<ITelefone> Telefones { get; set; }
        public IList<IEmail> Emails { get; set; }
    }
}
