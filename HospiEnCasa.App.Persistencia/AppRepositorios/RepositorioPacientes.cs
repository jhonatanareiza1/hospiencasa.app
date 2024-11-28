using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPacientes:IRepositorioPacientes
    {
        private readonly AppContext _appContext;
        public RepositorioPacientes(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Paciente CrearPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        public Paciente ConsultarPaciente(int idPaciente)
        {
           var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
           return pacienteEncontrado;
        }

        public IEnumerable<Paciente> ConsultarPacientes()
        {
            return _appContext.Pacientes;
        }

        public Paciente ActualizarPaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id ==paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombres = paciente.Nombres;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.FamiliarDesignado = paciente.FamiliarDesignado;
                pacienteEncontrado.Historia = paciente.Historia;
                pacienteEncontrado.SignoVital = paciente.SignoVital;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.Medico = paciente.Medico;

                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
        public void EliminarPaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null);
            return;

            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }
    }
}