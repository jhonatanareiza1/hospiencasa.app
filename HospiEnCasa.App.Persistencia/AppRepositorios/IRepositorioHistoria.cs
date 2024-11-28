using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioHistoria{
        Historia CrearEnHistoria(Historia historia);
        Historia ConsultarHistoria(int idHistoria);
        IEnumerable <Historia> ConsultarEnfermera();
        Historia ActualizarHistoria(Historia historia);
        void EliminarHistoria(int idHistoria);
    }
}