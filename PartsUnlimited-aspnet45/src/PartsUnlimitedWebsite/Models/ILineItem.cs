﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5th changes
namespace PartsUnlimited.Models
{
	public interface ILineItem
	{
		int Count { get; }

		Product Product { get; }
	}
}
