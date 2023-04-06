# example cmake project:
# https://gitlab.com/CLIUtils/modern-cmake/tree/master/examples/extended-project

cmake_minimum_required(VERSION 3.21.0)

add_definitions("-D_ENABLE_EXTENDED_ALIGNED_STORAGE")

# Project name and a few useful settings. Other commands can pick up the results
project(
  utilitydelta-test
  VERSION 1.0
  DESCRIPTION "UtilityDelta CPP CMAKE INTEROP CSHARP"
  LANGUAGES CXX)

# ## Require out-of-source builds
file(TO_CMAKE_PATH "${PROJECT_BINARY_DIR}/CMakeLists.txt" LOC_PATH)

if(EXISTS "${LOC_PATH}")
  message(FATAL_ERROR "You cannot build in a source directory (or any directory with a CMakeLists.txt file). Please make a build subdirectory. Feel free to remove CMakeCache.txt and CMakeFiles.")
endif()

# # Only do these if this is the main project, and not if it is included through add_subdirectory
if(CMAKE_PROJECT_NAME STREQUAL PROJECT_NAME)
  # Optionally set things like CMAKE_CXX_STANDARD, CMAKE_POSITION_INDEPENDENT_CODE here
  # Let's ensure -std=c++xx instead of -std=g++xx
  set(CMAKE_CXX_EXTENSIONS OFF)

  # Let's nicely support folders in IDEs
  set_property(GLOBAL PROPERTY USE_FOLDERS ON)

  # Testing only available if this is the main app
  # Note this needs to be done in the main CMakeLists
  # since it calls enable_testing, which must be in the
  # main CMakeLists.
  include(CTest)
endif()

include(FetchContent)

# The compiled library code is here
add_subdirectory(src)

# These are only available if this is the main app
if(CMAKE_PROJECT_NAME STREQUAL PROJECT_NAME)
  add_subdirectory(apps)
  add_subdirectory(interop)
  add_subdirectory(tests)
endif()
