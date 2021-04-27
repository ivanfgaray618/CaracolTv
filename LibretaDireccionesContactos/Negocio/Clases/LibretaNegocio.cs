namespace Negocio.Clases
{
    using Negocio.Interfaces;
    using Repositorio;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LibretaNegocio : ILibretaNegocio
    {
        private DireccionesContactosEntities db = new DireccionesContactosEntities();

        public IEnumerable<DireccionesContactos> ListarDireccionesContactos()
        {
            var lista = db.DireccionesContactos.ToList();
            return lista;
        }

        public DireccionesContactos DetalleContactos(DireccionesContactos contacto)
        {
            DireccionesContactos libretaContacto = db.DireccionesContactos.Find(contacto.IdContacto);
            return libretaContacto;
        }

        public bool CrearContacto(DireccionesContactos contacto)
        {
            try
            {
                db.DireccionesContactos.Add(contacto);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool EditarContacto(DireccionesContactos contacto)
        {
            try
            {
                DireccionesContactos libretaContacto = db.DireccionesContactos.Find(contacto.IdContacto);
                libretaContacto.Nombre = contacto.Nombre;
                libretaContacto.Direccion = contacto.Direccion;
                libretaContacto.Apellidos = contacto.Apellidos;
                libretaContacto.Ciudad = contacto.Ciudad;
                libretaContacto.Departamento = contacto.Departamento;
                libretaContacto.Genero = contacto.Genero;
                libretaContacto.Telefono = contacto.Telefono;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool EliminarContacto(DireccionesContactos contacto)
        {
            try
            {
                DireccionesContactos libretaContacto = db.DireccionesContactos.Find(contacto.IdContacto);
                db.DireccionesContactos.Remove(libretaContacto);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
