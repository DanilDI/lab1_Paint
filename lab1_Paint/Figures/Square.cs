﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Drawing;
using System.Text.Json.Serialization;

namespace lab1_Paint.Figures
{
	[Serializable]
	class Square:Polygon
	{
		public Square() { }
		[JsonConstructor]
		public Square(Color borderColor, Color fillColor, (int, int)[] vertices)
			: base(borderColor,  fillColor, vertices)
		{
			this.type = "Square";
		}
	}
}
