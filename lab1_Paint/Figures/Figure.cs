﻿using System;
using System.Drawing;
using System.Text.Json.Serialization;
using System.Windows.Forms;
namespace lab1_Paint.Figures
{
	[Serializable]
	abstract class Figure
	{

		public Color borderColor;
		public string type;
		//[JsonConstructor]
		public Figure( Color borderColor)
		{
			
			this.borderColor = borderColor;

		}
		public Figure() { }

		public void setBorderColor(Color color)
		{
			this.borderColor = color;
		}
		public Color getBorderColor()
		{
			return this.borderColor;
		}
		public string getType()
		{
			return this.type;
		}
	}

}
