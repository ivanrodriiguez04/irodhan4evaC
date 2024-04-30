using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Interfaz de los ficheros de esta aplicación
    /// irodhan -> 30/04/2024
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Método que carga el fichero al inicio de la aplicacion
        /// irodhan -> 30/04/2024
        /// </summary>
        public void cargaInicial(string rutaFicheroCitas);
        /// <summary>
        /// Método que muestra las consultas del día indicado
        /// irodhan -> 30/04/2024
        /// </summary>
        public void mostrarConsultas(List<PacienteDto> listaPacientesAntigua);
        /// <summary>
        /// Método que imprime en un fichero las consultas del día indicado
        /// irodhan -> 30/04/2024
        /// </summary>
        public void imprimirConsultas(List<PacienteDto> listaPacientesAntigua);
    }
}
