using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Negocio;

namespace ApiRest.Controller
{
    public class ProductoController : ApiController
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();
        // GET: Producto
        public IHttpActionResult Get()
        {
            return Ok(productoNegocio.All());
        }
    }
}