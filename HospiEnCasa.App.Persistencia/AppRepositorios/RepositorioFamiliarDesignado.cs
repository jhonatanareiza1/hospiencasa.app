using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliarDesignado:IRepositorioFamiliarDesignado
    {
        private readonly AppContext _appContext;
        public RepositorioFamiliarDesignado(AppContext appContext)
        {
            _appContext = appContext;
        }
        public FamiliarDesignado CrearFamiliar(FamiliarDesignado familiar){
            var familiarAdicionado = _appContext.FamiliaresDesignados.Add(familiar);
            _appContext.SaveChanges();
            return familiarAdicionado.Entity;
        }
        public FamiliarDesignado ConsultarFamiliar(int idFamiliarDesignado){
            var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(d => d.Id == idFamiliarDesignado);
            return familiarEncontrado;
        }
        public IEnumerable <FamiliarDesignado> ConsultarFamiliar()
        {
            return _appContext.FamiliaresDesignados;
        }
        public FamiliarDesignado ActualizarFamiliar(FamiliarDesignado familiar)
        {
            var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(d => d.Id == familiar.Id);
            if (familiarEncontrado != null)
            {
                familiarEncontrado.Nombres = familiarEncontrado.Nombres;
                familiarEncontrado.Apellidos = familiarEncontrado.Apellidos;
                familiarEncontrado.NumeroTelefono = familiarEncontrado.NumeroTelefono;
                familiarEncontrado.Genero = familiarEncontrado.Genero;
                familiarEncontrado.Parentesco = familiarEncontrado.Parentesco;
                familiarEncontrado.Correo = familiarEncontrado.Correo;

                _appContext.SaveChanges();
            }
            return familiarEncontrado;
        }
        public void EliminarFamiliar(int idFamiliarDesignado)
        {
            var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(d => d.Id == idFamiliarDesignado);
            if(familiarEncontrado == null);
            return;

            _appContext.FamiliaresDesignados.Remove(familiarEncontrado);
            _appContext.SaveChanges();
        }
    }
}