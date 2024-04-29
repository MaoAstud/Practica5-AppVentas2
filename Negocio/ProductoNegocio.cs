using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AccesoDatos;

namespace Negocio
{
    // NOMBRE APELLIDOS: Mao Astudillo
    // PARALELO: 
    // SI – INTEGRACIÓN DE SISTEMAS 
    // FECHA: 28/4/2024
    // PRÁCTICA No. 5
    public class ProductoNegocio
    {
        ProductoDatos productos;

        public ProductoNegocio()
        {
            this.productos = new ProductoDatos();
        }

        public List<Producto> All()
        {
            return productos.listaProducto();
        }

        public Producto ById(int id)
        {
            return productos.listaProducto().Where(p => p.idProducto == id).SingleOrDefault();
        }

        public bool insertarProducto(Producto producto)
        {
            return productos.insertarProducto(producto);
        }
    }
}
