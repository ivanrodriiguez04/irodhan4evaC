using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los menus de la aplicaión
    /// irodhan -> 30/04/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("|-------------------------|");
            Console.WriteLine("|          Menu           |");
            Console.WriteLine("|-------------------------|");
            Console.WriteLine("| 0. Cerrar Aplicación    |");
            Console.WriteLine("| 1. Registro de llegada  |");
            Console.WriteLine("| 2. Listado de consultas |");
            Console.WriteLine("|-------------------------|");
            Console.WriteLine("\nIntroduzca la opcion que desea usar: ");
            opcion=Console.ReadKey(true).KeyChar-('0');
            return opcion;
        }

        public int mostrarSubmenuEspecialidadYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("|------------------|");
            Console.WriteLine("|       Menu       |");
            Console.WriteLine("|------------------|");
            Console.WriteLine("| 0. Psicología    |");
            Console.WriteLine("| 1. Traumatología |");
            Console.WriteLine("| 2. Fiseoterapia  |");
            Console.WriteLine("|------------------|");
            Console.WriteLine("\nIntroduzca la opcion que desea usar: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }

        public int mostrarSubmenuListadoYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("|          Menu         |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("| 0. Volver             |");
            Console.WriteLine("| 1. Mostrar consultas  |");
            Console.WriteLine("| 2. Imprimir consultas |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("\nIntroduzca la opcion que desea usar: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}
