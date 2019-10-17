using System;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces
{
    public interface IDateTime
    {
        public DateTime DataCriacao { get; set; }
        public DateTime DataExclusao { get; set; }
        public DateTime UltimaModificacao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}