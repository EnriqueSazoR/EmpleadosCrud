// Modelo que implementara la tabla Empleado en la BD
using System.ComponentModel.DataAnnotations;

namespace MvcEmpleados.Models
{

    public class Empleado
    {
        // definir las propiedades de la clase.
        [Key]
        public int IdEmpleado { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [StringLength(30, MinimumLength = 10, ErrorMessage =("El nombre debe contener entre 10-30 caractres"))]
        public string NombreCompleto { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public string Correo { get; set; }
        public DateOnly FechaContrato { get; set; }
        public bool Estado { get; set; }
    }
}