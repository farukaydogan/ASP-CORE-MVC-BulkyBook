﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook2.Models;

public class Category
{
	[Key]
	public int Id { get; set; }

	[Required]
	public String Name { get; set; }

	public int DisplayOrder { get; set; }

	public DateTime CreatedDateTime { get; set; } = DateTime.Now;

}

