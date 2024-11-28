using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioEnfermera{
        Enfermera CrearEnfermera(Enfermera enfermera);
        Enfermera ConsultarEnfermera(int idEnfermera);
        IEnumerable <Enfermera> ConsultarEnfermera();
        Enfermera ActualizarEnfermera(Enfermera enfermera);
        void EliminarEnfermera(int idEnfermera);
    }
}