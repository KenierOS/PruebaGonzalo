using System;
using System.ComponentModel.DataAnnotations;

namespace ProductosAPI.Models;

public class ProductoInsert
{
     [Required]
     [StringLength(20)]
     public string Nombre { get; set; } = string.Empty;
      
    [Required]
    [Range(1, 10000000, ErrorMessage = "El precio no puede ser 0")]
    public decimal Precio  { get; set;}

     [Required]
     [Range(1, 20000000,ErrorMessage = "El stock no puede ser menor que 1" )]
    public int Stock { get; set; }  


}
