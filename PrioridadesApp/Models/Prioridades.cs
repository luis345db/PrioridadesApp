using System.ComponentModel.DataAnnotations;

namespace PrioridadesApp.Models
{
    public class Prioridades
    {
        [Key]
        public int PriodidadID { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]

        public string Descripcion { get; set; }

        public int DiasComprometidos { get; set; }
    }
}
