using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoMsm.Dtos
{
    /// <summary>
    /// Clase que contiene los campos y metodos de la clase alumnos 
    /// msm - 040624
    /// </summary>
    internal class AlumnosDto
    {
        //controladores
        long idAlumno;
        string nombreAlumno = "aaaa";
        string apellido1Alumno = "aaaa";
        string apellido2Alumno = "aaaa";
        string dni = "aaaa";
        string direccion = "aaaa";
        string telefono = "aaaa";
        string email = "aaaa";
        DateTime fechaNacimiento = new DateTime();

        //getters and setters
        public long IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string Apellido1Alumno { get => apellido1Alumno; set => apellido1Alumno = value; }
        public string Apellido2Alumno { get => apellido2Alumno; set => apellido2Alumno = value; }
        public string DNI { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }



        //toString

        override
        public string ToString()
        {
            string alumno = 
               string.Concat(dni, ";", nombreAlumno, ";", apellido1Alumno, ";", apellido2Alumno, ";", direccion, ";", telefono, ";", email, ";", fechaNacimiento.ToString("dd-MM-yyyy"), "\n");

            return alumno;
        }
    }
}
