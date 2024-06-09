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
        public static string rutaFichero = "C:\\Users\\Usuario\\Desktop\\ficheroAlumno.txt";
        StreamWriter sw;
        public void escribirAlumnos()
        {
            
            StreamWriter sw = new StreamWriter(rutaFichero);
            List<int> listaDni = new List<int>();

            try
            {
                foreach (AlumnosDto alumno in Program.listaAlumnos)
                {

                    int dniNumero = Convert.ToInt32(alumno.DNI.Substring(0, alumno.DNI.Length - 1));
                    listaDni.Add(dniNumero);


                }


                for (int i = 0; i < listaDni.Count - 1; i++)
                {
                    for (int y = 0; y < listaDni.Count - i - 1; y++)
                    {

                        if (listaDni[y] > listaDni[y + 1])
                        {
                            int aux = listaDni[y];
                            listaDni[y] = listaDni[y + 1];
                            listaDni[y + 1] = aux;

                        }

                    }
                }


                foreach (int dni in listaDni)
                {
                    foreach (AlumnosDto alumno in Program.listaAlumnos)
                    {
                        if (dni == Convert.ToInt32(alumno.DNI.Substring(0, alumno.DNI.Length - 1)))
                        {
                            sw.Write(alumno);
                        }
                    }
                }

                sw.Close();
            }
            catch (IOException ex)
            {
                using (sw = new StreamWriter(Program.rutaLog))
                {
                    sw.WriteLine("ERROR IO[]: " + ex.Message);
                }
            }
            
        }

        public void cargaInicial()
        {
            if (File.Exists(rutaFichero))
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
                    using (sw = new StreamWriter(Program.rutaLog))
                    {
                        sw.WriteLine("ERROR IO[]: " + ex.Message);
                    }
                }
                sr.Close();
            }

        }

    }
}
