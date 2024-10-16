﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Model.Models
{
	[Table("Menus")]
	public class Menu
	{
		public Menu()
		{
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]	
		
		public string Name { get; set; }

		[Required]
		[MaxLength (256)]	
		
		public string URL { get; set; }
		public int? DissplayOrder {  get; set; }

		[Required]
		public int GroupID { get; set; }	

		[ForeignKey("GroupID")]
		public virtual MenuGroup MenuGroup { get; set; }

		[MaxLength(10)]
		public string Target {  get; set; }

		[Required]
		public bool Status { get; set; }
	}

}
