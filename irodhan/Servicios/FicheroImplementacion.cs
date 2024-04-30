using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Clase que imnplementa a la interfaz de los ficheros de la aplicación
    /// irodhan -> 30/04/2024
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void cargaInicial(string rutaFicheroCitas,List<PacienteDto> lsitaPacientesAntigua)
        {
            if (File.Exists(rutaFicheroCitas))
            {
                try
                {
                    string[] lineas = File.ReadAllLines(rutaFicheroCitas);
                    foreach (string linea in lineas)
                    {
                        Console.WriteLine(linea);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            else
            {
                Console.WriteLine("El fichero no existe");
            }
        }

        public void imprimirConsultas()
        {
            PacienteDto paciente = new PacienteDto();
            Console.WriteLine("Elija una fecha (dd-MM-yyyy):");
            
        }

        public void mostrarConsultas()
        {   
            PacienteDto paciente = new PacienteDto();
            Console.WriteLine("Elija una fecha (dd-MM-yyyy):");

        }
    }
}
