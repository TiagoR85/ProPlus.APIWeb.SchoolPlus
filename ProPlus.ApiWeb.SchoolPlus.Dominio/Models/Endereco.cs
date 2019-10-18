using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Endereco : IEndereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Enums.TipoEndereco TipoEndereco { get; set; }
        public string Nro { get; set; }
        [NotMapped]
        public IMunicipio Municipio { get; set; }
        public int MunicipioID { get; set; }
        public Enums.Estado Estado { get; set; }
        public string Pais { get; set; }
        public int InstituicaoID { get; set; }
        public int UsuarioID { get; set; }
    }
}
