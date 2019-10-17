using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio
{
    public class Enums
    {
        public enum Status
        {
            Cursando, Aprovado, Reprovado, 
            [Description("Em recuperação")]
            Recuperacao
        }
        public enum TipoTelefone
        {
            Comercial, Residencial, Celular, 
            [Description("Urgência")]
            Urgencia
        }
        public enum Estado
        {
            AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI, RJ, RN, RS, RO, RR, SC, SP, SE, TO
        }
        public enum Sexo
        {
            Masculino, Femnino
        }

        public enum TipoEndereco
        {
            Comercial, Residencial
        }
    }
}
