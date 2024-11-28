using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly AppContext _appContext;
        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Historia CrearEnHistoria(Historia historia)
        {
            var historiaAdicionada = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionada.Entity;
        }
        public Historia ConsultarHistoria(int idHistoria)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(x => x.IdHistoria == idHistoria);
            return historiaEncontrada;
        }
        public IEnumerable <Historia> ConsultarEnfermera()
        {
            return _appContext.Historias;
        }
        public Historia ActualizarHistoria(Historia historia)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(x => x.IdHistoria == historia.IdHistoria);
            if (historiaEncontrada != null)
            {
                historiaEncontrada.Diagnostico = historia.Diagnostico;
                historiaEncontrada.Entorno = historia.Entorno;
                historiaEncontrada.SugerenciaCuidado = historia.SugerenciaCuidado;

                _appContext.SaveChanges();
            }
            return historiaEncontrada;
        }
        public void EliminarHistoria(int idHistoria)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(x => x.IdHistoria == idHistoria);
            if(historiaEncontrada ==null);
            return;

            _appContext.Historias.Remove(historiaEncontrada);
            _appContext.SaveChanges();
        }
    }
}