#pragma once
#include "myHeader.h"

MathClass::MathClass(double First, double Second)
{
	_operandOne = First;
	_operandTwo = Second;
}

double MathClass::Add()
{
	return _operandOne + _operandTwo;
}

double MathClass::Subtract()
{
	return _operandOne - _operandTwo;
}

double MathClass::Compose()
{
	return _operandOne * _operandTwo;
}

double MathClass::Divide()
{
	return _operandOne / _operandTwo;
}