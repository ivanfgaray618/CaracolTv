namespace Negocio.Interfaces
{
    using Repositorio;
    using System.Collections.Generic;

    public interface ILibretaNegocio
    {
        bool CrearContacto(DireccionesContactos contacto);
        DireccionesContactos DetalleContactos(DireccionesContactos contacto);
        bool EditarContacto(DireccionesContactos contacto);
        bool EliminarContacto(DireccionesContactos contacto);
        IEnumerable<DireccionesContactos> ListarDireccionesContactos();
    }
}