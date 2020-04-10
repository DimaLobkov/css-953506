#pragma hdrstop
#pragma argsused

extern "C" bool __declspec(dllexport) __stdcall isPowOfTwo(int num) {
	if (!(num & (num - 1))) return true;
	return false;
}