
find_package(GTest CONFIG REQUIRED)

# Tests need to be added as executables first
file(GLOB SRC_FILES *.cpp)
add_executable(utilitydelta-test-unittesting ${SRC_FILES})

target_link_libraries(utilitydelta-test-unittesting PRIVATE utilitydelta-test)
target_link_libraries(utilitydelta-test-unittesting PRIVATE GTest::gtest GTest::gtest_main)
target_compile_features(utilitydelta-test-unittesting PRIVATE cxx_std_20)

# If you register a test, then ctest and make test will run it.
# You can also run examples and check the output, as well.
add_test(NAME ctest-utilitydelta-test-unittesting COMMAND utilitydelta-test-unittesting) # Command can be a target
