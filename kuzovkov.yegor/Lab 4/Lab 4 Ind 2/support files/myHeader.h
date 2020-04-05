#pragma once

class MathClass
{
	private:
		double _operandOne;
		double _operandTwo;
	public:
		MathClass(double First, double Second);
		double Add();
		double Subtract();
		double Compose();
		double Divide();
};
