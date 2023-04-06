#include "utilitydelta-test/TestClass.hpp"

UtilityDelta::TestClass::~TestClass()
{
}

UtilityDelta::TestClass::TestClass(float value)
{
    _value = value;
}

float UtilityDelta::TestClass::DoThings()
{
    return 2.2 * _value;
}