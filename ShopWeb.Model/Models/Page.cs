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
	[Table("Pages")]
	public class Page : Auditable
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MaxLength(256)]
		public string Name { get; set; }
		[Column(TypeName = "varchar")]
		[Required]
		[MaxLength(256)]
		public string Alias { get; set; }
		public string Content { get; set; }
	}
}
