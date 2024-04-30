using irodhan.Dtos;
using irodhan.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// irodhan -> 30/04/2024
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// irodhan -> 30/04/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            //Ficheros
            string rutaFicheroCitas = "C:\\Users\\csi22-irodhan\\Desktop\\Programacion\\Examen4ºEva\\Ficheros\\citas.txt";

            //Listas
            List<PacienteDto> listaPacientes = new List<PacienteDto>();
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            OperativaInterfaz oI = new OperativaImplementacion();
            FicheroInterfaz fI= new FicheroImplementacion();

            //Variables
            int opcionSeleccionada = 0,opcion2=0;
            bool cerrarMenu=false;
            //Realizamos la carga inicial del archivo
            fI.cargaInicial(rutaFicheroCitas);
            //Creamos un bucle para el control de flujo de la aplicación
            try
            {
                while (!cerrarMenu)
                {
                    //Recogemos la opcion indicada por el usuario
                    opcionSeleccionada = mI.mostrarMenuYSeleccion();
                    //Creamos un switch para las distintas opciones del menu
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            Console.WriteLine("[INFO] - Ha seleccionado la opción 0");
                            Console.WriteLine("[INFO] - La aplicación va a cerrarse");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("[INFO] - Ha seleccionado la opción 1");
                            Console.WriteLine("[INFO] - Va a registrar su llegada");
                            oI.registroLlegada(listaPacientes);
                            break;
                        case 2:
                            Console.WriteLine("[INFO] - Ha seleccionado la opción 2");
                            Console.WriteLine("[INFO] - Se va a listar las consultas");
                            opcion2=mI.mostrarSubmenuListadoYSeleccion();
                            switch (opcion2) 
                            {
                                case 0:
                                    Console.WriteLine("[INFO] - Ha seleccionado la opción 0");
                                    Console.WriteLine("[INFO] -  Va a volve ral menu principal");
                                    break;
                                case 1:
                                    Console.WriteLine("[INFO] - Ha seleccionado la opción 1");
                                    Console.WriteLine("[INFO] - Ha seleccionado  mostrar consultas");
                                    fI.mostrarConsultas(listaPacientes);
                                    break;
                                case 2:
                                    Console.WriteLine("[INFO] - Ha seleccionado la opción 2");
                                    Console.WriteLine("[INFO] - Ha seleccionado imprimir consultas");
                                    fI.imprimirConsultas(listaPacientes);
                                    break;
                                default:
                                    Console.WriteLine("[INFO] - La opcion indicada anteriormente no coincide con ninguna opcion del menu");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("[INFO] - La opcion indicada anteriormente no coincide con ninguna opcion del menu");
                            break;
                    }
                }
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
