cmake_minimum_required(VERSION 3.28)
project(DivineForce)

set(CMAKE_CXX_STANDARD 20)

set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/${CMAKE_PROJECT_NAME})

list(PREPEND CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/cmake)

include(spdlog)
include(safetyhook)
include(inipp)

add_library(${CMAKE_PROJECT_NAME} SHARED main.cpp helper.hpp)

set_target_properties(${CMAKE_PROJECT_NAME} PROPERTIES SUFFIX ".asi")

target_link_libraries(${CMAKE_PROJECT_NAME} PRIVATE spdlog safetyhook inipp)

file(COPY ${CMAKE_CURRENT_SOURCE_DIR}/resource/${CMAKE_PROJECT_NAME}Fix.ini DESTINATION ${CMAKE_RUNTIME_OUTPUT_DIRECTORY})
file(COPY ${CMAKE_CURRENT_SOURCE_DIR}/resource/XINPUT9_1_0.dll DESTINATION ${CMAKE_RUNTIME_OUTPUT_DIRECTORY})