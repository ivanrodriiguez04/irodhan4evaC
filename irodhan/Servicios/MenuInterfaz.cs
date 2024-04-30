using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Interfaz de los menus de la aplicación
    /// irodhan -> 30/04/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menu principal y obtiene  la opción indicada por el usuario
        /// irodhan  -> 30/04/2024
        /// </summary>
        /// <returns>Devuelve la opción que desea utilizar el usuario</returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Método que muestra el submenu del listado y obtiene la opcion indicada por el usuario
        /// irodhan -> 30/04/2024
        /// </summary>
        /// <returns>Devuelve la opción que desea utilizar el usuario</returns>
        public int mostrarSubmenuListadoYSeleccion();

        /// <summary>
        /// Método que muestra el submenu de las especialidades y obtiene la opcion indicada por el usuario
        /// irodhan -> 30/04/2024
        /// </summary>
        /// <returns>Devuelve la opción que desea utilizar el usuario</returns>
        public int mostrarSubmenuEspecialidadYSeleccion();
    }
}
