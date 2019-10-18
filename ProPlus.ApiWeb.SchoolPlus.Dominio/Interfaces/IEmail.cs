using static ProPlus.ApiWeb.SchoolPlus.Dominio.Enums;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IEmail
    {
        public int EmailId { get; set; }
        public int InstituicaoID { get; set; }
        public int UsuarioID { get; set; }
        public string EnderecoEmail { get; set; }
    }
}