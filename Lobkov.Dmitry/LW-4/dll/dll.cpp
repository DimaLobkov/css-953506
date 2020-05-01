#include "pch.h"
#pragma hdrstop
#pragma argsused

extern "C" float __declspec(dllexport) __stdcall VolumePrlpd(float a, float b, float c) 
{
	return a * b * c;
}