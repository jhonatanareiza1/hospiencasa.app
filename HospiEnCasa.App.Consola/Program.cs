using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
        class Program
        {
            private static IRepositorioPacientes _repoPaciente = new RepositorioPacientes(new Persistencia.AppContext());
            static void Main(string[] args)
            {
    
                Console.WriteLine("Shutting down");
                Console.WriteLine("Press any key to exit...");
                CrearPaciente();

            }

            private static void CrearPaciente()
            {
                var paciente = new Paciente
                {
                    Nombres = "Jhonatan",
                    Apellidos = "Areiza Ramirez",
                    NumeroTelefono = "123456",
                    Genero = Genero.Masculino,
                    Direccion = "cassa con carrera",
                    Latitud = 8.25F,
                    Longitud = 25.69F,
                    Ciudad = "Medellin",
                    FechaNacimiento = new DateTime (1985, 04, 23)
                };
                _repoPaciente.CrearPaciente(paciente);
            }
        }


}
