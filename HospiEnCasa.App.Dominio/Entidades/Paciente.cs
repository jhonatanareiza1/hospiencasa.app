using System;

namespace HospiEnCasa.App.Dominio{
    public class Paciente: Persona{
        public string Direccion { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string Ciudad { get; set;}
        public DateTime FechaNacimiento { get; set; }
        public FamiliarDesignado FamiliarDesignado { get; set; }
        public Historia Historia { get; set; }
        public SignoVital SignoVital { get; set; }
        public Enfermera Enfermera { get; set; }
        public Medico Medico{ get; set; }

    }
}