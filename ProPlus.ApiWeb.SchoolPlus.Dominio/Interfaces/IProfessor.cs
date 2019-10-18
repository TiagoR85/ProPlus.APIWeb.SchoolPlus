namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IProfessor
    {
        public int DisciplinaID { get; set; }
        public int ProfessorID { get; set; }
        public int InstituicaoID { get; set; }
        public IPessoa Usuario { get; set; }
    }
}