
using System;
using ProductosAPI.Models;

namespace ProductosAPI.Services;

public class ProductosDataStore
{
    public List<Producto> Productos {get; set;}
    public static ProductosDataStore Current { get; } = new ProductosDataStore();

    public ProductosDataStore()
    {
        Productos = new List<Producto>(){
            new Producto(){
                Id = 1,
                Nombre = "Warhammer",
                Precio = 1000,
                Stock  = 1200,


            },
            new Producto(){
                Id = 2,
                Nombre = "Dota",
                Precio = 150,
                Stock  = 100,


            },
            new Producto(){
                Id = 3,
                Nombre = "Dofus",
                Precio = 15,
                Stock  = 10,


            }, 
            new Producto(){
                Id = 4,
                Nombre = "Civilization 6",
                Precio = 200000,
                Stock  = 2200,


            }

        };
        
    }

}
