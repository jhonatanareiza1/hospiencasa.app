using System;

namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
        public int IdSignoVital { get; set; }
        public DateTime FechaHora { get; set; }
        public Signo Signo{ get; set; }
        public float Valor { get; set; }
    }
}