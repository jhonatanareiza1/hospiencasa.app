using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioSugerenciaCuidado{
        SugerenciaCuidado CrearSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        SugerenciaCuidado ConsultarSugerenciaCuidado(int idSugerenciaCuidado);
        IEnumerable <SugerenciaCuidado> ConsultarSugerenciaCuidado();
        SugerenciaCuidado ActualizarSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        void EliminarSugerenciaCuidado(int idSugerenciaCuidado);
    }
}