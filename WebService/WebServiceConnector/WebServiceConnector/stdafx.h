// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

#include "targetver.h"

#include <stdio.h>
#include <tchar.h>

#define WIN32_LEAN_AND_MEAN // Disable client timeout for testing. Default is 10000 milliseconds.
#define ATL_SOCK_TIMEOUT INFINITE // Minimum system requirements are Windows 98, Windows NT 4.0, or later
#define _WIN32_WINDOWS 0x0410
#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS      // some CString constructors will be explicit

#include <atlbase.h>
#include "helloworld.h"
#include <conio.h>
#include <iostream>
#include <atlstr.h>

// TODO: reference additional headers your program requires here
