using static ProPlus.ApiWeb.SchoolPlus.Dominio.Enums;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IEndereco
    {
        public int EnderecoId { get; set; }
        public int InstituicaoID { get; set; }
        public int UsuarioID { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
        public string Nro { get; set; }
        public IMunicipio Municipio { get; set; }
        public int MunicipioID { get; set; }
        public Estado Estado { get; set; }
        public string Pais { get; set; }
    }
}