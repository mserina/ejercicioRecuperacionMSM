using ejercicioRepasoMsm.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoMsm.Servicios
{
    
    /// <summary>
    /// Contiene la logica de los metodos del servicio operacion 
    /// msm - 040624
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public static string dniInsertado;

        public void darAltaAlumno()
        {
            bool masAlumno = true;
            do
            {

                AlumnosDto alumnos = new AlumnosDto();

                Console.WriteLine("Inserte nombre");
                alumnos.NombreAlumno = Console.ReadLine();
                Console.WriteLine("Inserte 1ºapellido");
                alumnos.Apellido1Alumno = Console.ReadLine();
                Console.WriteLine("Inserte 2ºapellido");
                alumnos.Apellido2Alumno = Console.ReadLine();
                Console.WriteLine("Inserte dni");
                alumnos.DNI = Console.ReadLine();
                Console.WriteLine("Inserte direccion");
                alumnos.Direccion = Console.ReadLine();
                Console.WriteLine("Inserte telefono");
                alumnos.Telefono = Console.ReadLine();
                Console.WriteLine("Inserte email");
                alumnos.Email = Console.ReadLine();
                Console.WriteLine("Inserte fecha de nacimiento");
                alumnos.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());


                Program.listaAlumnos.Add(alumnos);

                Console.WriteLine(" ");
                Console.WriteLine("Quieres añadir mas alumnos s/n");
                string respuesta = Console.ReadLine();

                if (respuesta.Equals("n"))
                {
                    masAlumno = false;
                }
                Console.WriteLine(" ");
            }
            while (masAlumno);
        }

        public void borrarAlumno()
        {
            Console.WriteLine("Inserte el dni del alumno a borrar");
            dniInsertado = Console.ReadLine();

            foreach (AlumnosDto alumnos in Program.listaAlumnos)
            {
                if (alumnos.DNI.Equals(dniInsertado))
                {
                    Program.listaAlumnos.Remove(alumnos);

                    Console.WriteLine(" ");
                    Console.WriteLine("El alumno ha sido eliminado");
                    Console.WriteLine(" ");
                }
            }

        }

        public void mostrarAlumno()
        {
            foreach (AlumnosDto alumnos in Program.listaAlumnos)
            {
                Console.WriteLine(alumnos.ToString());
            }
        }

        public void modificarAlumno()
        {
            MenuInterfaz mi = new MenuImplementacion();
            bool cerrar = false; 
            while (!cerrar)
            {
                Console.WriteLine("Inserte el dni del alumno a modificar");
                dniInsertado = Console.ReadLine();
                foreach (AlumnosDto alumnos in Program.listaAlumnos)
                {
                    if (alumnos.DNI.Equals(dniInsertado))
                    {
                        cerrar = true;
                        mi.logicaMenu2();

                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("El dni insertado no existe, inserte uno distinto");
                        Console.WriteLine(" ");
                        
                    }
                }
            }

            

        }

        public void camposAModificar(string campo)
        {
            foreach (AlumnosDto alumnos in Program.listaAlumnos)
            {
                if (alumnos.DNI.Equals(dniInsertado))
                {
                    if (campo.Equals("N"))
                    {
                        Console.WriteLine("Inserte el nuevo nombre");
                        alumnos.NombreAlumno = Console.ReadLine();
                        Console.WriteLine(" ");
                    }
                    if (campo.Equals("A1"))
                    {
                        Console.WriteLine("Inserte el nuevo apellido1");
                        alumnos.Apellido1Alumno = Console.ReadLine();
                        Console.WriteLine(" ");
                    }
                    if (campo.Equals("A2"))
                    {
                        Console.WriteLine("Inserte el nuevo apellido2");
                        alumnos.Apellido2Alumno = Console.ReadLine();
                        Console.WriteLine(" ");
                    }
                    if (campo.Equals("D"))
                    {
                        Console.WriteLine("Inserte el nuevo direccion");
                        alumnos.Direccion = Console.ReadLine();
                        Console.WriteLine(" ");
                    }
                    if (campo.Equals("T"))
                    {
                        Console.WriteLine("Inserte el nuevo telefono");
                        alumnos.Telefono = Console.ReadLine();
                        Console.WriteLine(" ");
                    }
                    if (campo.Equals("E"))
                    {
                        Console.WriteLine("Inserte el nuevo email");
                        alumnos.Email = Console.ReadLine();
                        Console.WriteLine(" ");
                    }
                    if (campo.Equals("F"))
                    {
                        Console.WriteLine("Inserte el nuevo fecha");
                        alumnos.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine(" ");
                    }
                }
            }
        }


    }
}
