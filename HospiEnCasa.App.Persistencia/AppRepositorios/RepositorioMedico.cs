using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext;
        public RepositorioMedico(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Medico CrearMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }
        public Medico ConsultarEnfermera(int idMedico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
            return medicoEncontrado;
        }
        public IEnumerable <Medico> ConsultarMedico()
        {
            return _appContext.Medicos;
        }
        public Medico ActualizarEnfermera(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.FirstOrDefault(m => m.Id == medico.Id);
            if (medicoAdicionado != null)
            {
                medicoAdicionado.Nombres = medico.Nombres;
                medicoAdicionado.Apellidos = medico.Apellidos;
                medicoAdicionado.NumeroTelefono = medico.NumeroTelefono;
                medicoAdicionado.Genero = medico.Genero;
                medicoAdicionado.Especialidad = medico.Especialidad;
                medicoAdicionado.Codigo = medico.Codigo;
                medicoAdicionado.RegistroRhetus = medico.RegistroRhetus;
                medicoAdicionado.Enfermera = medico.Enfermera;

                _appContext.SaveChanges();
            }
            return medicoAdicionado;
        }
        public void EliminarMedico(int idMedico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
            if(medicoEncontrado == null);
            return;
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }
    }
}