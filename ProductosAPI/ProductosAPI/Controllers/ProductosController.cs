using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProductosAPI.Helpers;
using ProductosAPI.Models;
using ProductosAPI.Services;

namespace ProductosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetProductos()
        {
            return Ok (ProductosDataStore.Current.Productos);
        }

        [HttpGet("{productoId}")]

        public ActionResult<Producto> GetProducto(int productoId)
        {
            var Producto = ProductosDataStore.Current.Productos.FirstOrDefault(x => x.Id ==productoId);

            if (Producto == null)
             return NotFound(Mensajes.Producto.NotFound);

            return  Ok(Producto);

        }


        [HttpPost]

        public ActionResult<Producto> PostProducto(ProductoInsert productoInsert)
        {
            var maxProductoId = ProductosDataStore.Current.Productos.Max(x => x.Id);

            var ProductoNuevo = new Producto(){
                Id = maxProductoId + 1,
                Nombre = productoInsert.Nombre,
                Precio = productoInsert.Precio,
                Stock  = productoInsert.Stock,
            };
            ProductosDataStore.Current.Productos.Add(ProductoNuevo);

            return CreatedAtAction(nameof(GetProducto),
            new { productoId = ProductoNuevo.Id},
            ProductoNuevo

            );

        }

        [HttpPut("{productoId}")]

        public ActionResult<Producto> PutProducto(int productoId, ProductoInsert productoInsert)
        {
            var Producto = ProductosDataStore.Current.Productos.FirstOrDefault(x => x.Id ==productoId);

            if (Producto == null)
             return NotFound(Mensajes.Producto.NotFound);

            Producto.Nombre = productoInsert.Nombre;
            Producto.Precio = productoInsert.Precio;
            Producto.Stock  = productoInsert.Stock;

            return NoContent();

        }


        [HttpDelete("{productoId}")]

        public ActionResult<Producto> DeleteProducto(int productoId)
        {
           var Producto = ProductosDataStore.Current.Productos.FirstOrDefault(x => x.Id ==productoId);

            if (Producto == null)
             return NotFound(Mensajes.Producto.NotFound);

            ProductosDataStore.Current.Productos.Remove(Producto);

            return NoContent();
        }


    }
}
