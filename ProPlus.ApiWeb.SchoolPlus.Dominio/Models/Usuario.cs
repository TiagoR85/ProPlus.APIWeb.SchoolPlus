using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Usuario : IPessoa
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Nascimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Enums.Sexo Sexualidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Altura_cm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Peso_g { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IEndereco> Endereços { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IEmail> Emails { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<ITelefone> Telefones { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IResponsavel> Responsaveis { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDadosEscolares DadosEscolares { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDadosGamefication DadosGamefication { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Ativo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDateTime RegistroTempo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
