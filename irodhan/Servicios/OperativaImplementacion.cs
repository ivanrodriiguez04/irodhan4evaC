using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de la opertativa de la aplicación
    /// irodhan -> 30/04/2024
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void registroLlegada(List<PacienteDto> listaPacientesAntigua)
        {
            //Creamos el objeto paciente
            PacienteDto paciente = new PacienteDto();
            bool validacion=false;
            
            do 
            { 
                //Pedimos el dni al paciente
                Console.WriteLine("Introduce su dni: ");
                paciente.NumeroDniPaciente = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce la letra de su dni: ");
                paciente.LetraDniPaciente=Convert.ToChar(Console.ReadLine());
                int numero=paciente.NumeroDniPaciente;
                char letraValidar = paciente.LetraDniPaciente;
                validacion=validarDni(numero,letraValidar);
                if ()
                {
                    Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.");
                }
                else
                {
                    Console.WriteLine("No dispone de cita disponible");
                }
            } while (!validacion);
            
        }

        private bool validarDni(int numero,char letraValidar) 
        {
            PacienteDto paciente = new PacienteDto();
            bool valido=false;
            char letra='O';
            //Calculamos la letra
            Console.WriteLine(numero);
            int resto = numero % 23;
            Console.WriteLine(resto);
            Console.WriteLine(letraValidar);

            switch (resto) 
            {
                case 0:
                    letra = 'T';
                    break;
                case 1:
                    letra = 'R';
                    break;
                case 2:
                    letra = 'W';
                    break;
                case 3:
                    letra = 'A';
                    break;
                case 4:
                    letra = 'G';
                    break;
                case 5:
                    letra = 'M';
                    break;
                case 6:
                    letra = 'Y';
                    break;
                case 7:
                    letra = 'F';
                    break;
                case 8:
                    letra = 'P';
                    break;
                case 9:
                    letra = 'D';
                    break;
                case 10:
                    letra = 'X';
                    break;
                case 11:
                    letra = 'B';
                    break;
                case 12:
                    letra = 'N';
                    break;
                case 13:
                    letra = 'J';
                    break;
                case 14:
                    letra = 'Z';
                    break;
                case 15:
                    letra = 'S';
                    break;
                case 16:
                    letra = 'Q';
                    break;
                case 17:
                    letra = 'V';
                    break;
                case 18:
                    letra = 'H';
                    break;
                case 19:
                    letra = 'L';
                    break;
                case 20:
                    letra = 'C';
                    break;
                case 21:
                    letra = 'K';
                    break;
                case 22:
                    letra = 'E';
                    break;
            }
            
            if (letra.Equals(letraValidar)) 
            { 
                valido = true;
                Console.WriteLine("El dni es valido");
            } 
            else 
            {
                valido = false;
                Console.WriteLine("El dni no es valido");
            }
            return valido;
        }
    }
}



/*for (int f = 0; f < listaCliente.Count; f++)
        {
            for (int c = 0; c < listaCliente.Count - 1 - f; c++)
            {
                // ( cambiando el simbolo mayor que, cambiamos la condicion a cumplir )
                if (listaCliente[c + 1].FechaLlegadaAControl > listaCliente[c].FechaLlegadaAControl)
                {
                    Vehiculo aux = listaCliente[c + 1];
                    listaCliente[c + 1] = listaCliente[c];
                    listaCliente[c] = aux;
                }

            }
        }



        return listaCliente;
*/