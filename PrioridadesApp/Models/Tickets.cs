using System.ComponentModel.DataAnnotations;

namespace PrioridadesApp.Models
{
	public class Tickets
	{
		[Key]
		public int TicketId { get; set; }

		[Required(ErrorMessage = "El campo {0} es requerido")]
		public string Fecha { get; set; }

		[Required(ErrorMessage = "El campo {0} es requerido")]
		public int ClienteId { get; set; }

		[Required(ErrorMessage = "El campo {0} es requerido")]
		public int SistemaId { get; set; }

		[Required(ErrorMessage = "El campo {0} es requerido")]
		public int PriodidadID { get; set; }

		[Required(ErrorMessage = "El campo {0} es requerido")]
		public string? SolicitadoPor { get; set; }

		[Required(ErrorMessage = "El campo {0} es requerido")]
		public string? Asunto { get; set; }

		[Required(ErrorMessage = "El campo {0} es requerido")]
		public string? Descripcion { get; set; }
		
	}
}