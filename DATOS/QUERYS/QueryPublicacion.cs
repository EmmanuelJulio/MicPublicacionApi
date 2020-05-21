using DOMINIO.ENTIDADES;
using DOMINIO.QUERYS;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace DATOS.QUERYS
{
    public class QueryPublicacion : IQueryPublicacion
    {
        private readonly IDbConnection conexion;
        private readonly Compiler SqlKataCompiler;

        public QueryPublicacion(IDbConnection conexion, Compiler SqlKataCompiler)
        {
            this.conexion = conexion;
            this.SqlKataCompiler = SqlKataCompiler;
        }

        public List<Publicacion> GetPublicaciones()
        {
            var db = new QueryFactory(conexion, SqlKataCompiler);
            var Publicacion = db.Query("Publicaciones").
               Select("ProductoID").Get<Publicacion>().ToList();

            return Publicacion;  

        }

        public Publicacion GetPublicacionesID(int publicacionID)
        {
            var db = new QueryFactory(conexion, SqlKataCompiler);
            var Publicacion = db.Query("Publicaciones").
                Select("ProductoID").
                Where("ID", "=", publicacionID).
                FirstOrDefault<Publicacion>();
               

            return Publicacion;
        }
    }
}
