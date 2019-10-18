namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IAmigo
    {
        public int AmigoID { get; set; }
        public IPessoa Usuario { get; set; }
    }
}