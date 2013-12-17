// WebServiceConnector.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


void AccessService(){
using namespace std;
HelloWorld::CHelloWorld hw;
BSTR* res = new BSTR();
HRESULT hr=hw.HelloWorld(res); wcout<<*res;
}

int _tmain(int argc, _TCHAR* argv[])
{ if (SUCCEEDED(CoInitialize(NULL)))
{ AccessService(); CoUninitialize(); }
return 0;
}

