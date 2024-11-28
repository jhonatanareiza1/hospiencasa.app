using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPersona{
        Persona CrearPersona(Persona persona);
        Persona ConsultarEPersona(int idPersona);
        IEnumerable <Persona> ConsultarPersona();
        Persona ActualizarPersona(Persona persona);
        void EliminarPersona(int idPersona);
    }
}