using Negocio.Clases;
using Negocio.Interfaces;
using Repositorio;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LibretaDireccionesContactos.Controllers
{
    public class LibretaController : Controller
    {

        private readonly ILibretaNegocio libretaNegocio;

        public LibretaController()
        {
            libretaNegocio = new LibretaNegocio();
        }

        public ActionResult Index()
        {
            IEnumerable<DireccionesContactos> lista = libretaNegocio.ListarDireccionesContactos();
            return View(lista);
        }

        public ActionResult Administracion()
        {
            IEnumerable<DireccionesContactos> lista = libretaNegocio.ListarDireccionesContactos();
            return View(lista);
        }


        public ActionResult Create()
        {
            return View();

        }


        [HttpPost]
        public ActionResult Create(DireccionesContactos contacto)
        {
            try
            {
                libretaNegocio.CrearContacto(contacto);
                return RedirectToAction("Administracion");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            var contacto = new DireccionesContactos()
            {
                IdContacto = id
            };

            return View(libretaNegocio.DetalleContactos(contacto));
        }


        [HttpPost]
        public ActionResult Edit(DireccionesContactos contacto)
        {
            try
            {
                libretaNegocio.EditarContacto(contacto);
                return RedirectToAction("Administracion");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            var contacto = new DireccionesContactos()
            {
                IdContacto = id
            };

            var resultado = libretaNegocio.EliminarContacto(contacto);
            return RedirectToAction("Administracion");
        }
    }
}
