﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392_AffiliLinker.Core.Utils
{
	[AttributeUsage(AttributeTargets.All)]
	public class CustomName : Attribute
	{
		public string Name { get; set; }
		public CustomName(string name)
		{
			Name = name;
		}
	}
}
