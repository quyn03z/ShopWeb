using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Model.Models
{
	[Table("PostTags")]
	public class PostTag
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]	
		public int PostId { get; set; }

		[Key]
		[Column(TypeName = "varchar")]
		[MaxLength(50)]
		public string TagId { get; set; }

		[ForeignKey("PostId")]
		public virtual Post Post { get; set; }

		[ForeignKey("TagId")]
		public virtual Tag Tag { get; set; }

	}
}
