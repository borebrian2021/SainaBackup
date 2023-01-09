using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Models
{
	public class Receipt_counter
	{
		[Key]
		public string Id { get; set; }

		[Required]
		public string Date { get; set; }

	}
}
