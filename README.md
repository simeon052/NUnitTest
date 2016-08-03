# NUnitTest

NUnit Test project for Xamarin.Mac.Mobile with GUIUnit <https://github.com/mono/guiunit>.


But, GUIUnit doesn't work well with PCL Project with this error.

----
NUnitLite 0.9.0 (.NET 4.5 Debug)
Copyright 2012, Charlie Poole

Runtime Environment -
    OS Version: Unix 15.6.0.0
  Mono Version: 4.0.50524.0

Tests run: 2, Passed: 1, Errors: 1, Failures: 0, Inconclusive: 0
  Not run: 0, Invalid: 0, Ignored: 0, Skipped: 0
Elapsed time: 00:00:00.1400000

Errors and Failures:

1) Test2 (NUnitTest.Mac.MyClass.Test2)
   System.IO.FileNotFoundException : Could not load file or assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies.
  at (wrapper managed-to-native) System.Reflection.MonoMethod:InternalInvoke (System.Reflection.MonoMethod,object,object[],System.Exception&)
  at System.Reflection.MonoMethod.Invoke (System.Object obj, BindingFlags invokeAttr, System.Reflection.Binder binder, System.Object[] parameters, System.Globalization.CultureInfo culture) [0x00038] in /Users/builder/data/lanes/3539/f37444ae/source/maccore/_mac-build/Library/Frameworks/Xamarin.Mac.framework/Versions/git/src/mono/mcs/class/corlib/System.Reflection/MonoMethod.cs:295 

