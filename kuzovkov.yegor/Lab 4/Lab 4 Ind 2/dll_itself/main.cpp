#include "pch.h"
#include "C:\Users\\George_PC\Desktop\Labs\sem 2\ISP\Lab 4\Lab 4 Ind 2\Support\myHeader.h"
#include "C:\Users\George_PC\Desktop\Labs\sem 2\ISP\Lab 4\Lab 4 Ind 2\Support\mySource.cpp"

extern "C" __declspec(dllexport) __stdcall double Add(double var_x, double var_y)
{
	MathClass MC(var_x, var_y);
	return MC.Add();
}

extern "C" __declspec(dllexport) __stdcall double Subtract(double var_x, double var_y)
{
	MathClass MC(var_x, var_y);
	return MC.Subtract();
}

extern "C" __declspec(dllexport) __fastcall double Compose(double var_x, double var_y)
{
	MathClass MC(var_x, var_y);
	return MC.Compose();
}

extern "C" __declspec(dllexport) __fastcall double Divide(double var_x, double var_y)
{
	MathClass MC(var_x, var_y);
	return MC.Divide();
}
