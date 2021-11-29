using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1_2
{
	class Circle : AbstractShape
	{
		public Circle()
		{
			Parameter = new double[1];
		}
		public override string getMessage()
		{
			return "Обєкт створено: " + ShapeName + "\nПлоща: " + getSquare().ToString();
		}

		public override double getSquare()
		{
			return 3.14 * Parameter[0] * Parameter[0];
		}
	}
}
