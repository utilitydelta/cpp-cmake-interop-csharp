#include "utilitydelta-test/TestClass.hpp"
#include <gtest/gtest.h>

using namespace UtilityDelta;

TEST(TestClassTests, Test1)
{
	UtilityDelta::TestClass test{44.33};
	float temp = test.DoThings();
	ASSERT_NEAR(97.526, temp, 0.001);
}