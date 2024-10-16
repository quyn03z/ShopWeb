using ShopWeb.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShopWeb.Model.Models
{
	[Table("Products")]
	public class Product : Auditable
	{
		public Product() { }

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		[MaxLength(256)]	
		
		public string Name { get; set; }

		[Required]
		[MaxLength(256)]

		public string Alias { get; set; }
		[Required]	
		
		public int CategoryId { get; set; }

		[MaxLength(256)]

		public string Image {  get; set; }
		[Column(TypeName = "xml")]
		public string MoreImages { get; set; }
		[Required]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal Price { get; set; }
		[Column(TypeName = "decimal(18, 2)")]
		public decimal? PromotionPrice { get; set; }
		public int? Warranty { get; set; }
		[MaxLength(500)]
		public string Description { get; set; }
		public string Content { get; set; }
		public bool? HomeFlag { get; set; }
		public bool? HotFlag { get; set; }
		public int? ViewCount { get; set; }

		[ForeignKey("CategoryId")]
		public virtual ProductCategory ProductCategory { get; set; }
	}
}
