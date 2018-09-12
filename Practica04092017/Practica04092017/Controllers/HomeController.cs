using Practica04092017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica04092017.Controllers
{
    public class HomeController : Controller
    {
        MateriaServicio servicioM = new MateriaServicio();

        public ActionResult Index()
        {
            Mensaje m = new Mensaje("Bienvenidos a web 3");
            return View(m);
        }

        public ActionResult Listar()
        {
            List<Materia> lista = servicioM.getAll();

            return View(lista);
        }



        public ActionResult Detalle(int id)
        {
            MateriaServicio ms = new MateriaServicio();
            Materia m = ms.obtenerPorId(id);

            return View(m);
        }


        public ActionResult Eliminar(int id)
        {
            var ms = new MateriaServicio(); //var en tiempo de ejecucion seria MateriaServicio
            ms.eliminarPorId(id);

            return RedirectToAction("Listar", "Home");
            // return Redirect("/Materias/Listar");
            // return View("Listar", ms.getAll()); no se recomienda

        }



        [HttpGet] // esto era el get que va al form en java 
        public ActionResult Modificar(int id)
        {
            Materia m = servicioM.obtenerPorId(id);
            return View(m);

        }

        [HttpPost]
        public ActionResult ModificarDatos(FormCollection f)
        {
            String id = f["IdMateria"];
            String nom = f["Nombre"];
            String cant = f["CantidadAlumnos"];
            int idEntero = int.Parse(id);

            Materia m = servicioM.Editar(idEntero, nom, cant);

            return View(m);
        }

        public ActionResult FormAdd()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Agregar(Materia m)
        {
            servicioM.Crear(m);

            return RedirectToAction("Listar", "Home");
        } 




    }





}