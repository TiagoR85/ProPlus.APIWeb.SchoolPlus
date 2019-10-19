using ProPlus.ApiWeb.SchoolPlus.Dominio.Models;
using ProPlus.APIWeb.SchoolPlus.DbContext;
using ProPlus.Comum.Repositorios.Entity;

namespace ProPlus.APIWeb.SchoolPlus.Repositorios
{
    public class RepositorioQuestionario : RepositorioComum<Questionario, int>
    {
        public RepositorioQuestionario(SchoolPlusDbContext context) : base(context)
        {
        }
    }
}
