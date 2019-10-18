using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Responsavel : IResponsavel
    {
        public int ResponsavelID { get; set; }
        public IPessoa Usuario { get; set; }
        public int UsuarioID { get; set; }
    }
}
