using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioMedico{
        Medico CrearMedico(Medico medico);
        Medico ConsultarEnfermera(int idMedico);
        IEnumerable <Medico> ConsultarMedico();
        Medico ActualizarEnfermera(Medico medico);
        void EliminarMedico(int idMedico);
    }
}