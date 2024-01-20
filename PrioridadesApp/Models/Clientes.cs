using System.ComponentModel.DataAnnotations;

namespace PrioridadesApp.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="El Campo {0} es Requerido")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public int Celular { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string RNC { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string Email { get; set; }

        public string Direccion { get; set; }
    }
}
