#pragma hdrstop
#pragma argsused
#include <math.h>

extern "C" double __declspec(dllexport) __stdcall Area (double side)
 {return   side*side*pow(3,0.5)/4; }

extern "C" double __declspec(dllexport) __stdcall Angle (double amside)
{return 180*(amside-2)/amside;}



