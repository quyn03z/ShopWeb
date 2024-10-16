﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Model.Models
{
	[Table("Tags")]
	public class Tag
	{
		public Tag() { }

		[Key]
		[MaxLength(50)]
		[Column(TypeName = "varchar")]
		public string Id { get; set; }
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }

		[Required]
		[MaxLength(50)]
		public string Type { get; set; }
	}
}
