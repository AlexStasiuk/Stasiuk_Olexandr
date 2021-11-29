using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1_2
{
	class Rectangle : AbstractShape
	{
		public Rectangle()
		{
			Parameter = new double[2];
		}
		public override string getMessage()
		{
			return "Обєкт створено: " + ShapeName +"\nПлоща: " + getSquare().ToString();
		}

		public override double getSquare()
		{
			return Parameter[0] * Parameter[1];
		}
	}
}
