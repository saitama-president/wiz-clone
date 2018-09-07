#! /bin/bash

mcs \
  -r ~/.nuget/packages/newtonsoft.json/11.0.2/lib/netstandard1.0/Newtonsoft.Json.dll \
 *.cs \
 -out:test.exe
mono test.exe
