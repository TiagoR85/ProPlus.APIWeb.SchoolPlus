using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IAluno
    {
        public int AlunoID { get; set; }
        public IPessoa Usuario { get; set; }
    }
}
