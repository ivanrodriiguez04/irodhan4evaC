using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Dtos
{
    /// <summary>
    /// Clase que contiene los dtos de los pacientes
    /// irodhan -> 30/04/2024
    /// </summary>
    internal class PacienteDto
    {
        //Atributos
        long idPaciente;
        int numeroDniPaciente = 0;
        char letraDniPaciente= 'a';
        string nombrePaciente = "aaaaa";
        string apellidosPaciente = "aaaaa";
        string especialidad = "aaaaa";
        DateTime fchCita = DateTime.Now;
        bool asistencia=false;
        //Constructores
        public PacienteDto(long idPaciente, int numeroDniPaciente, char letraDniPaciente, string nombrePaciente, string apellidosPaciente, string especialidad, DateTime fchCita, bool asistencia)
        {
            this.idPaciente = idPaciente;
            this.numeroDniPaciente = numeroDniPaciente;
            this.letraDniPaciente = letraDniPaciente;
            this.nombrePaciente = nombrePaciente;
            this.apellidosPaciente = apellidosPaciente;
            this.especialidad = especialidad;
            this.fchCita = fchCita;
            this.asistencia = asistencia;
        }
        public PacienteDto()
        {
        }
        //Getters & Setters
        public long IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int NumeroDniPaciente { get => numeroDniPaciente; set => numeroDniPaciente = value; }
        public char LetraDniPaciente { get => letraDniPaciente; set => letraDniPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string ApellidosPaciente { get => apellidosPaciente; set => apellidosPaciente = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FchCita { get => fchCita; set => fchCita = value; }
        public bool Asistencia { get => asistencia; set => asistencia = value; }

    }
}
