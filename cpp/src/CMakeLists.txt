# Note that headers are optional, and do not affect add_library, but they will not
# show up in IDEs unless they are listed in add_library.
file(GLOB HEADER_LIST CONFIGURE_DEPENDS "../include/utilitydelta-test/*.hpp")

# Make an automatic library - will be static or dynamic based on user setting
file(GLOB SRC_FILES *.cpp)
add_library(utilitydelta-test ${SRC_FILES} ${HEADER_LIST})

# We need this directory, and users of our library will need it too
target_include_directories(utilitydelta-test PUBLIC ../include)

# All users of this library will need at least C++20
target_compile_features(utilitydelta-test PUBLIC cxx_std_20)

# IDEs should put the headers in a nice place
source_group(
  TREE "${PROJECT_SOURCE_DIR}/include"
  PREFIX "Header Files"
  FILES ${HEADER_LIST})