#pragma once

#include <stdlib.h>
#include <string.h>
#include <stdint.h>

#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#include <Windows.h>
#include <Winsock2.h>
#include <ws2tcpip.h>
#else
#include <unistd.h>
#include <pthread.h>
#include <sys/time.h>
#include <arpa/inet.h>
#endif

#ifdef _WIN32
# define LC_WINDOWS
#else
# define LC_POSIX
# if defined(__APPLE__)
#  define LC_DARWIN
# endif
#endif

#include <stdio.h>
#include "Limelight.h"

#if defined(LC_WINDOWS)
void LimelogWindows(char* Format, ...);
#define Limelog(s, ...) \
    LimelogWindows(s, ##__VA_ARGS__)
#else
#define Limelog(s, ...) \
    fprintf(stderr, s, ##__VA_ARGS__)
#endif

#if defined(LC_WINDOWS)
 #include <crtdbg.h>
 #ifdef LC_DEBUG
  #define LC_ASSERT(x) __analysis_assume(x); \
                       _ASSERTE(x)
 #else
  #define LC_ASSERT(x)
 #endif
#else
 #ifndef LC_DEBUG
  #define NDEBUG
 #endif
 #include <assert.h>
 #define LC_ASSERT(x) assert(x)
#endif

int initializePlatform(void);
void cleanupPlatform(void);

uint64_t PltGetMillis(void);
