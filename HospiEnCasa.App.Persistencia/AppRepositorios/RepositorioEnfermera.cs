using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioEnfermera:IRepositorioEnfermera
    {
        private readonly AppContext _appContext;
        public RepositorioEnfermera(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Enfermera CrearEnfermera(Enfermera enfermera)
        {
            var enfermeraAdicionado = _appContext.Enfermeras.Add(enfermera);
            _appContext.SaveChanges();
            return enfermeraAdicionado.Entity;
        }
        public Enfermera ConsultarEnfermera(int idEnfermera)
        {
            var enfermeraEncontrada = _appContext.Enfermeras.FirstOrDefault(e => e.Id == idEnfermera);
            return enfermeraEncontrada;
        }
        public IEnumerable <Enfermera> ConsultarEnfermera()
        {
            return _appContext.Enfermeras;
        }
        public Enfermera ActualizarEnfermera(Enfermera enfermera)
        {
            var enfermeraEncontrada = _appContext.Enfermeras.FirstOrDefault(e => e.Id == enfermera.Id);
            if (enfermeraEncontrada != null)
            {
                enfermeraEncontrada.Nombres = enfermera.Nombres;
                enfermeraEncontrada.Apellidos = enfermera.Apellidos;
                enfermeraEncontrada.NumeroTelefono = enfermera.NumeroTelefono;
                enfermeraEncontrada.Genero = enfermera.Genero;
                enfermeraEncontrada.TargetaProfesional = enfermera.TargetaProfesional;
                enfermeraEncontrada.HorasLaborales = enfermera.HorasLaborales;

                _appContext.SaveChanges();
            }
            return enfermeraEncontrada;
        }
        public void EliminarEnfermera(int idEnfermera)
        {
            var enfermeraEncontrada = _appContext.Enfermeras.FirstOrDefault(e => e.Id == idEnfermera);
            if(enfermeraEncontrada == null);
            return;

            _appContext.Enfermeras.Remove(enfermeraEncontrada);
            _appContext.SaveChanges();
        }
    }
}