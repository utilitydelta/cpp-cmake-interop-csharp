#include <iostream>
#include "utilitydelta-test/TestClass.hpp"

using namespace UtilityDelta;

int main(int argc, char **argv)
{
	UtilityDelta::TestClass test{44.33};
	std::cout << "Hello World: " << test.DoThings() << std::endl;

	return 0;
}