using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext;
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Persona CrearPersona(Persona persona)
        {
            var personaAdicionada = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionada.Entity;
        }
        public Persona ConsultarEPersona(int idPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            return personaEncontrada;
        }
        public IEnumerable <Persona> ConsultarPersona(){
            return _appContext.Personas;
        }
        public Persona ActualizarPersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if (personaEncontrada != null)
            {
                personaEncontrada.Nombres = persona.Nombres;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.NumeroTelefono = persona.NumeroTelefono;
                personaEncontrada.Genero = persona.Genero;

                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
        public void EliminarPersona(int idPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
                if (personaEncontrada == null);
                return;

                _appContext.Personas.Remove(personaEncontrada);
                _appContext.SaveChanges();
            
        }
    }
}