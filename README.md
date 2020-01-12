# pythonnetmod
[WIP] A mod and fork of pythonnet, for getting a lite P/Invoke CLR python

## Run with sharpdevelop  
see pythonnet_sharpdevelop.sln  
it copy python27.dll to output folder in project  

## About unmanaged code debugging  
* Please use vs2013 to open pythonnet_vs2013.sln  
* Please check 'Enable native code debugging' in pythonnet_vs2013 project Debug tab  
see https://www.technipages.com/visual-studio-native-code-debugging  
* When debugging, click menu 'Debug->Exception' and enable all exceptions  

## TODO / Bugs    
* min code  
* run eval failed under windows xp, AppDomain GCHandle problem, maybe the result var is dropped by gc.  
 