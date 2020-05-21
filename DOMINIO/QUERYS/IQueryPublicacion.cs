using DOMINIO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOMINIO.QUERYS
{
    public interface IQueryPublicacion
    {
        List<Publicacion> GetPublicaciones();
        Publicacion GetPublicacionesID(int publicacionID);

        
    }
}
