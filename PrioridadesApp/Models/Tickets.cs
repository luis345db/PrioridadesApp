using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrioridadesApp.Models
{
	public class Tickets
	{
		[Key]
		public int TicketId { get; set; }


		[Required(ErrorMessage = "El campo {0} es requerido")]
		[DataType(DataType.Date)]
		public DateTime Fecha { get; set; }

		[ForeignKey("Clientes")]
		[Required(ErrorMessage = "El campo {0} es requerido")]
		public int ClienteId { get; set; }

		[ForeignKey("Sistemas")]
		[Required(ErrorMessage = "El campo {0} es requerido")]
		public int SistemaId { get; set; }

		[ForeignKey("Prioridades")]
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