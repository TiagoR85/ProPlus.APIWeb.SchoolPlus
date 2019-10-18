using static ProPlus.ApiWeb.SchoolPlus.Dominio.Enums;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface ITelefone
    {
        public int InstituicaoID { get; set; }
        public int UsuarioID { get; set; }
        public int TelefoneId { get; set; }
        public string NroTelefone { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
    }
}