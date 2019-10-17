namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IPontuacao
    {
        public int PontuacaoID { get; set; }
        public int UsuarioID { get; set; }
        public string NomeJogo { get; set; }
    }
}