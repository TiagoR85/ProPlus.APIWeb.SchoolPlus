namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IDadosVisual
    {
        public int UsuarioID { get; set; }
        public int ClaID { get; set; }
        public int DadosVisualID { get; set; }
        public string CaminhoRelativo { get; set; }
    }
}