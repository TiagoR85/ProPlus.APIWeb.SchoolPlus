using ProPlus.ApiWeb.SchoolPlus.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class Endereco : IEndereco
    {
        public int EnderecoId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Logradouro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Bairro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Latitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Longitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Enums.TipoEndereco TipoEndereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMunicipio Municipio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Enums.Estado Estado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Pais { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
