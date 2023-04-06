#include "combaseapi.h"
#include "utilitydelta-test/TestClass.hpp"

extern "C"
{
	__declspec(dllexport) int __stdcall UtilityDeltaTestClassDoThings(float value, float *result)
	{
		UtilityDelta::TestClass test{44.33};
		float temp = test.DoThings();
		*result = temp;
		return 0;
	}
}