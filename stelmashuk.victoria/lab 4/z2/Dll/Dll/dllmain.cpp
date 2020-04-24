// dllmain.cpp : Определяет точку входа для приложения DLL.
#include "pch.h"
#include "framework.h"

extern "C" double __declspec(dllexport) __stdcall IMT(double weight, double heigth)
{
	return weight / heigth / heigth;
}
