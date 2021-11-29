using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1_2
{
	abstract class AbstractShape
	{
		private string shapeName;
		private double[] parameter;
		public  string ShapeName
		{
			get { return shapeName; }
			set { shapeName = value; }
		}
		public  double[] Parameter
		{
			get
			{
				return parameter;
			}
			set
			{
				parameter = value;
			}
		}
		public abstract double getSquare();
		public abstract string getMessage();
	}
}
