using ProPlus.ApiWeb.SchoolPlus.Dominio;
using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProPlus.APIWeb.SchoolPlus.Dto
{
    public class DtoUsuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "Minimo 2, máximo 20 caracteres")]
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Enums.Sexo Sexualidade { get; set; }
        
        //[Range(1, 3, ErrorMessage = "Altura minima 155cm")]
        public int Altura_cm { get; set; }
        public int Peso_g { get; set; }
        public IList<IEndereco> Endereços { get; set; }
        public IList<IEmail> Emails { get; set; }
        public IList<ITelefone> Telefones { get; set; }
        public IList<IResponsavel> Responsaveis { get; set; }
        public IDadosEscolares DadosEscolares { get; set; }
        public IDadosGamefication DadosGamefication { get; set; }
        public bool Ativo { get; set; }
        public IDateTime RegistroTempo { get; set; }
    }
}
