using ProPlus.ApiWeb.SchoolPlus.Dominio.Models;
using ProPlus.APIWeb.SchoolPlus.DbContext;
using ProPlus.Comum.Repositorios.Entity;

namespace ProPlus.APIWeb.SchoolPlus.Repositorios.Entity
{
    public class RepositorioUsuario : RepositorioComum<Usuario, int>
    {
        public RepositorioUsuario(SchoolPlusDbContext context) : base(context)
        {
        }
    }
}
