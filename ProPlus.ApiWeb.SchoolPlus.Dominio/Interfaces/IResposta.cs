using System.Collections.Generic;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IResposta
    {
        public int RespostaID { get; set; }
        public int RespostaCorreta { get; set; }
        public IEnumerable<IResposta> RespostasPossiveis { get; set; }
    }
}