using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioSignoVital
    {
        SignoVital CrearSignoVtal(SignoVital signoVital);
        SignoVital ConsultarSignoVital(int idSignoVital);
        IEnumerable<SignoVital> ConsultarSignoVital();
        SignoVital ActualizarSignoVtal(SignoVital signoVital);
        void EliminarSignoVital(int idSignoVital);
    }
}