
#pragma once

namespace UtilityDelta
{
    class TestClass
    {
    public:
        TestClass(float value);
        ~TestClass();
        float DoThings();

    private:
        float _value;
    };
}