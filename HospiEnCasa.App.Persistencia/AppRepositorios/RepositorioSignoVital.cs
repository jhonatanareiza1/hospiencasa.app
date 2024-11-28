using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSignoVital:IRepositorioSignoVital
    {
        private readonly AppContext _appContext;
        public RepositorioSignoVital(AppContext appContext)
        {
            _appContext = appContext;
        }
        public SignoVital CrearSignoVtal(SignoVital signoVital)
        {
            var SignoVitalAdicionado = _appContext.SignosVitales.Add(signoVital);
            _appContext.SaveChanges();
            return SignoVitalAdicionado.Entity;
        }
        public SignoVital ConsultarSignoVital(int idSignoVital)
        {
            var signoEncontrado = _appContext.SignosVitales.FirstOrDefault(s => s.IdSignoVital == idSignoVital);
            return signoEncontrado;
        }
        public IEnumerable<SignoVital> ConsultarSignoVital()
        {
            return _appContext.SignosVitales;
        }
        public SignoVital ActualizarSignoVtal(SignoVital signoVital)
        {
            var signoEncontrado = _appContext.SignosVitales.FirstOrDefault(s => s.IdSignoVital == signoVital.IdSignoVital);
            if (signoEncontrado != null)
            {
                signoEncontrado.FechaHora = signoVital.FechaHora;
                signoEncontrado.Signo = signoVital.Signo;
                signoEncontrado.Valor = signoVital.Valor;

                _appContext.SaveChanges();
            }
            return signoEncontrado;
        }
        public void EliminarSignoVital(int idSignoVital){
            var signoEncontrado = _appContext.SignosVitales.FirstOrDefault(s => s.IdSignoVital == idSignoVital);
            if(signoEncontrado == null)
            return;

            _appContext.SignosVitales.Remove(signoEncontrado);
            _appContext.SaveChanges();
        }

    }
}