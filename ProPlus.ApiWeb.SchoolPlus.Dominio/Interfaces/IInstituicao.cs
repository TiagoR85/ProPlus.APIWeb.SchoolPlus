using System.Collections.Generic;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IInstituicao
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
