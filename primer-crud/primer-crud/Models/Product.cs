using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace primer_crud.Models
{
    public class Product
    {
        public int Id { get; set; }
       
        public string? Name { get; set; }
        
        public DateTime Fecha { get; set; }
        public string Clave { get; set; }
        
    }
}
