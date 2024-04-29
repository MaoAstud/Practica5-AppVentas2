using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Api.Controllers
{
    // NOMBRE APELLIDOS: Mao Astudillo
    // PARALELO: 
    // SI – INTEGRACIÓN DE SISTEMAS 
    // FECHA: 28/4/2024
    // PRÁCTICA No. 5
    public class ProductoController : ApiController
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();
        // GET: Producto
        public IHttpActionResult Get()
        {
            return Ok(productoNegocio.All());
        }

        public IHttpActionResult ById(int id)
        {
            Producto producto = productoNegocio.ById(id);
            
            if(producto != null)
            {
                return Ok(producto);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Producto prod)
        {
            if (productoNegocio.insertarProducto(prod))
            {
                return Ok("Insertado Correctamente");
            }
            return BadRequest("Ha ocurrido un error");
        }
    }
}