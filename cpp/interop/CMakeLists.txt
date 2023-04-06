add_library(utilitydelta-interop SHARED interop.cpp)
target_compile_features(utilitydelta-interop PRIVATE cxx_std_20)
target_link_libraries(utilitydelta-interop PRIVATE utilitydelta-test)