#include "pch.h"
#include "framework.h"
#include "Dll3.h"

#pragma hdrstop
#pragma argsused

extern "C" double __declspec(dllexport) __stdcall  Sum(double a, double b)
{
	return a + b;
}

extern "C" double __declspec(dllexport) __stdcall Sub(double a, double b)
{
	return a - b;
}

extern "C" double __declspec(dllexport) __stdcall Div(double a, double b)
{
	return a / b;
}

extern "C"  double __declspec(dllexport) __stdcall Mult(double a, double b)
{
	return a * b;
}

extern "C" int __declspec(dllexport) __stdcall Mod(int a, int b)
{
	return a % b;
}


