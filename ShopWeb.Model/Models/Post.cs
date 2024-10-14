﻿using ShopWeb.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Model.Models
{
	[Table("Posts")]
	public class Post : Auditable
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MaxLength(256)]	
		public string Name { get; set; }
		[Required]
		[MaxLength(256)]
		[Column(TypeName = "varchar")]
		public string Alias { get; set; }
		[Required]
		public int CategoryId {  get; set; }

		[MaxLength(256)]
		public string Image {  get; set; }
		[MaxLength(500)]
		public string Description { get; set; }
		public string Content { get; set; }
		public bool? HomeFlag { get; set; }
		public bool? HotFlag { get; set;}
		public int? ViewCount { get; set;}

		[ForeignKey("CategoryId")]
		public virtual PostCategory PostCategory { get; set; }
	}
}
