using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Model.Models
{
	[Table("OrderDetails")]
	public class OrderDetail
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderId { get; set; }

		[Key]		
		public int ProductId { get; set; }
		public int Quantity { get; set; }

		[ForeignKey("OrderId")]
		public virtual Order Order { get; set; }

		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }	
	}
}
