using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1_2
{
	class Square : AbstractShape
	{
		public Square()
		{
			Parameter = new double[1];
		}
		public override string getMessage()
		{
			return "Обєкт створено: " + ShapeName + "\nПлоща: " + getSquare().ToString();
		}

		public override double getSquare()
		{
			return Parameter[0] * Parameter[0];
		}
	}
}
