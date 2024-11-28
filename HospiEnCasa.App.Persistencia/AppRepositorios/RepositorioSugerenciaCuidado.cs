using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSugerenciaCuidado : IRepositorioSugerenciaCuidado
    {
        private readonly AppContext _appContext;
        public RepositorioSugerenciaCuidado(AppContext appContext)
        {_appContext = appContext;}
        public SugerenciaCuidado CrearSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaCuidadoAdicionado = _appContext.SugerenciasCuidados.Add(sugerenciaCuidado);
            _appContext.SaveChanges();
            return sugerenciaCuidadoAdicionado.Entity;
        }
        public SugerenciaCuidado ConsultarSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado = _appContext.SugerenciasCuidados.FirstOrDefault(x => x.Id == idSugerenciaCuidado);
            return sugerenciaCuidadoEncontrado;
        }
        public IEnumerable <SugerenciaCuidado> ConsultarSugerenciaCuidado()
        {
            return _appContext.SugerenciasCuidados;
        }
        public SugerenciaCuidado ActualizarSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado = _appContext.SugerenciasCuidados.FirstOrDefault(x => x.Id == sugerenciaCuidado.Id);
            if (sugerenciaCuidadoEncontrado != null)
            {
                sugerenciaCuidadoEncontrado.FechaHora = sugerenciaCuidado.FechaHora;
                sugerenciaCuidadoEncontrado.Descripcion = sugerenciaCuidado.Descripcion;

                _appContext.SaveChanges();
            }
            return sugerenciaCuidadoEncontrado;
        }
        public void EliminarSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado = _appContext.SugerenciasCuidados.FirstOrDefault(x => x.Id == idSugerenciaCuidado);
            if(sugerenciaCuidadoEncontrado == null);
            return;

            _appContext.SugerenciasCuidados.Remove(sugerenciaCuidadoEncontrado);
            _appContext.SaveChanges();
        }

    }
}