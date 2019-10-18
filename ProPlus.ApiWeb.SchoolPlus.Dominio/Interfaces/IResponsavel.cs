namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IResponsavel
    {
        public int ResponsavelID { get; set; }
        public IPessoa Usuario { get; set; }
        public int UsuarioID { get; set; }
    }
}