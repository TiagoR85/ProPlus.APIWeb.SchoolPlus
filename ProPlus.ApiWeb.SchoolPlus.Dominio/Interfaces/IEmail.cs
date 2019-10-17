using static ProPlus.ApiWeb.SchoolPlus.Dominio.Enums;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IEmail
    {
        public int EmailId { get; set; }
        public string EnderecoEmail { get; set; }
    }
}