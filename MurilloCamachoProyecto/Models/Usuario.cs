using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MurilloCamachoProyecto.Models
{
    public class Usuario
    {
        
    public int Id { get; set; }
        [Required]
        [Column(TypeName="varchar(10)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
       
        public string clave { get; set; }
        [Required]

        public Boolean estado { get; set; }

    }
}
