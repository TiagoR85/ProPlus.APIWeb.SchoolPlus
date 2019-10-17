using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Professor : IProfessor
    {
        public IPessoa Usuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
