using System;

namespace HospiEnCasa.App.Dominio
{
    public class Medico:Persona
    {
        public string Especialidad { get; set; }
        public string Codigo { get; set; }
        public string RegistroRhetus { get; set; }
        public Enfermera Enfermera { get; set; }

    }
}