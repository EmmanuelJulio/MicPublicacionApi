using DOMINIO.COMANDOS;
using DOMINIO.ENTIDADES;
using DOMINIO.QUERYS;
using System;
using System.Collections.Generic;
using System.Text;

namespace APLICACION.SERVICIOS
{

    public interface IPublicacionServicio 
    {

       Publicacion CrearPublicacion(int productoID);
        List<Publicacion> GetPublicaciones();
        Publicacion GetPublicacionesID(int publicacionID);


    }
    public class PublicacionServicio : IPublicacionServicio
    {

        private readonly IGenericsRepository repository;
        private readonly IQueryPublicacion query;

        public PublicacionServicio(IGenericsRepository repository, IQueryPublicacion query)
        {
            this.repository = repository;
            this.query = query;
        }


        public Publicacion CrearPublicacion(int productoID)
        {
            Publicacion publicacion = new Publicacion
            {
                ProductoID = productoID
            };
            return repository.Agregar<Publicacion>(publicacion);
        }

        public List<Publicacion> GetPublicaciones()
        {
            return query.GetPublicaciones();
        }

        public Publicacion GetPublicacionesID(int publicacionID)
        {
            return query.GetPublicacionesID(publicacionID);
        }
    }
}
