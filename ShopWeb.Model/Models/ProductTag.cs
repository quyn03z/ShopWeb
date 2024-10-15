using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Model.Models
{
	[Table("ProductTags")]
	public class ProductTag
	{
		[Key]
		public int ProductId { get; set; }

		[Key]
		[Column(TypeName = "varchar")]
		[MaxLength(50)]
		public string TagId { get; set; }

		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }

		[ForeignKey("TagId")]
		public virtual Tag Tag { get; set; }
	}
}
