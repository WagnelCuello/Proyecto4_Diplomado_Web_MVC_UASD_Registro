using Proyecto4_Diplomado_Web_MVC_UASD_Registro.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace Proyecto4_Diplomado_Web_MVC_UASD_Registro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormularioVisita()
        {
            return View();
        }

        public ActionResult FormularioEstudiantes()
        {
            return View();
        }

        public ActionResult CargaDatos()
        {
            LibroEstudiantes libro = new LibroEstudiantes();
            libro.Nombre = Request.Form["nombre"].ToString();
            libro.Telefono = Request.Form["telefono"].ToString();
            libro.Cedula = Request.Form["cedula"].ToString();
            libro.Correo = Request.Form["correo"].ToString();
            libro.Grabar(libro);

            //string nombre = Request.Form["nombre"].ToString();
            //string comentarios = Request.Form["comentarios"].ToString();
            //LibroVisitas libro = new LibroVisitas();
            //libro.Grabar(nombre, comentarios);
            return View();
        }

        public ActionResult ListadoVisitas()
        {
            LibroVisitas libro = new LibroVisitas();
            string todo = libro.Leer();
            ViewData["libro"] = todo;
            return View();
        }

        public ActionResult ListadoEstudiantes()
        {
            LibroEstudiantes libro = new LibroEstudiantes();
            string todo = libro.Leer();
            ViewData["libro"] = todo;
            return View(libro);
        }
    }
}