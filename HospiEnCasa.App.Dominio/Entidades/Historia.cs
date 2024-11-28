using System;

namespace HospiEnCasa.App.Dominio
{
    public class Historia
    {
        public int IdHistoria { get; set; }
        public string Diagnostico { get; set; }
        public string Entorno { get; set; }
        public SugerenciaCuidado SugerenciaCuidado{ get; set; }
    }
}