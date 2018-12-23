using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Proyecto4_Diplomado_Web_MVC_UASD_Registro.Models
{
    public class LibroEstudiantes
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        private string path = HostingEnvironment.MapPath("~") + "App_Data/Estudiantes.txt";

        public void Grabar(LibroEstudiantes libro)
        {
            List<LibroEstudiantes> estudiantes = new List<LibroEstudiantes>();
            estudiantes.Add(libro);

            StreamWriter archivo = new StreamWriter(path, true);
            archivo.WriteLine(libro.Nombre + "\t" + libro.Cedula + "\t" + libro.Telefono + "\t" + libro.Correo + "<hr>");
            archivo.Close();

            //StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "App_Data/Estudiantes.txt", true);
            //archivo.WriteLine("Nombre: " + libro.Nombre + "<br>Comentarios: " + comentarios + "<hr>");
            //archivo.Close();
        }

        public string Leer()
        {
            StreamReader archivo = new StreamReader(path);
            string dato = archivo.ReadToEnd();
            archivo.Close();
            return dato;

            //StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/Estudiantes.txt");
            //string dato = archivo.ReadToEnd();
            //archivo.Close();
            //return dato;
        }
    }
}