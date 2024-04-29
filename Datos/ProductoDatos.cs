using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // NOMBRE APELLIDOS: Mao Astudillo
    // PARALELO: 
    // SI – INTEGRACIÓN DE SISTEMAS 
    // FECHA: 28/4/2024
    // PRÁCTICA No. 5

    public class ProductoDatos
    {
        serviciosEntities db;

        public ProductoDatos()
        {
            db = new serviciosEntities();
        }

        public List<Producto> listaProducto() {
        
            return db.Producto.ToList();

        }

        public bool insertarProducto(Producto producto) { 
        
            return db.Producto.Add(producto) != null ? true : false;

        }

        public ObjectResult clienteSP()
        {

            return db.SP_Clientes();

        }
    }
}
