﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Proyecto4_Diplomado_Web_MVC_UASD_Registro.Models
{
    public class LibroVisitas
    {
        public void Grabar(string nombre, string comentarios)
        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "App_Data/Datos.txt", true);
            archivo.WriteLine("Nombre: " + nombre + "<br>Comentarios: " + comentarios + "<hr>");
            archivo.Close();
        }

        public string Leer()
        {
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt");
            string dato = archivo.ReadToEnd();
            archivo.Close();
            return dato;
        }
    }
}