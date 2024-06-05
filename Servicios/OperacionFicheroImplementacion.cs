using ejercicioRepasoMsm.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoMsm.Servicios
{
    /// <summary>
    /// Clase que contiene la logica de los metodos de los servcios de ficheros
    /// msm - 050624
    /// </summary>
    internal class OperacionFicheroImplementacion : OperacionFicheroInterfaz
    {
        public static string rutaFichero = "C:\\Users\\csi23-mserina\\Desktop\\FICHEROS\\ficheroAlumno.txt";
        public void escribirAlumnos()
        {
            
            StreamWriter sw = new StreamWriter(rutaFichero);
            foreach(AlumnosDto alumno in Program.listaAlumnos)
            {
                sw.Write(alumno.ToString());
            }
           sw.Close();
            
        }

        public void cargaInicial()
        {
            StreamReader sr = new StreamReader(rutaFichero);
            string lineas;

            try
            {
                while ((lineas = sr.ReadLine()) != null)
                {
                    string[] campos = lineas.Split(";");
                    AlumnosDto alumno = new AlumnosDto();

                    alumno.DNI = campos[0];
                    alumno.NombreAlumno = campos[1];
                    alumno.Apellido1Alumno = campos[2];
                    alumno.Apellido2Alumno = campos[3];
                    alumno.Direccion = campos[4];
                    alumno.Telefono = campos[5];
                    alumno.Email = campos[6];
                    alumno.FechaNacimiento = Convert.ToDateTime(campos[7]);

                    Program.listaAlumnos.Add(alumno);
                }
            }
            catch (IOException ex)
            {
                using (StreamWriter sw = new StreamWriter(Program.rutaLog))
                {
                    sw.WriteLine("ERROR IO[]: " + ex.Message);
                }
            }
            sr.Close();

        }

    }
}
