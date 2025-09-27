include(FetchContent)

FetchContent_Declare(
        safetyhook
        GIT_REPOSITORY https://github.com/cursey/safetyhook.git
        GIT_TAG v0.6.9
)

FetchContent_MakeAvailable(safetyhook)