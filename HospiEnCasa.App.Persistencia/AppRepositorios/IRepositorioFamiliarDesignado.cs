using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
      public interface IRepositorioFamiliarDesignado{
        FamiliarDesignado CrearFamiliar(FamiliarDesignado familiar);
        FamiliarDesignado ConsultarFamiliar(int idFamiliarDesignado);
        IEnumerable <FamiliarDesignado> ConsultarFamiliar();
        FamiliarDesignado ActualizarFamiliar(FamiliarDesignado familiar);
        void EliminarFamiliar(int idFamiliarDesignado);
    }
}