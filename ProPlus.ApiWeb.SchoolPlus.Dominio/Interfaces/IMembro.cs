namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IMembro
    {
        public int MembroID { get; set; }
        public IPessoa Usuario { get; set; }
        public IDadosVisual DadosVisual { get; set; }
    }
}