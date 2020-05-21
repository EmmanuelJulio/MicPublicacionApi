using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APLICACION.SERVICIOS;
using DOMINIO.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioPublicacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacionController : ControllerBase
    {
        private readonly IPublicacionServicio service;

        public PublicacionController(IPublicacionServicio service)
        {
            this.service = service;
        }
        [Route("InsertarPublicacion")]
        [HttpPost]
        public IActionResult Post(int productoID)
        {
            try
            {
                return new JsonResult(service.CrearPublicacion(productoID)) { StatusCode = 201 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }


        [Route("TraerPublicaciones")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new JsonResult(service.GetPublicaciones()) { StatusCode = 201 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }



        [Route("TraerPublicacionesID")]
        [HttpGet]
        public IActionResult Get(int publicacionID)
        {
            try
            {
                return new JsonResult(service.GetPublicacionesID(publicacionID)) { StatusCode = 201 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }



    }
}