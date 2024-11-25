# Minimal reproduction of IL2026 Trim Warnings

This project reproduces an IL2026 trim warning coming from source generated code when trying to publish to a net9.0 
target. 

## Steps to reproduce

```zsh
dotnet restore
dotnet publish -c Release --framework net9.0-ios18.0 /t:Run /p:_DeviceName=<DEVICE_ID>
```

## Expected behavior

The project should build and run on the specified device.

## Actual behavior

The project fails to build with the following errors:

```
  Sentry.Samples.Maui net9.0-ios18.0 failed with 3 error(s) (20.4s) → bin/Release/net9.0-ios18.0/ios-arm64/Sentry.Samples.Maui.dll
    /TrimWarning/obj/Release/net9.0-ios18.0/ios-arm64/Microsoft.Maui.Controls.SourceGen/Microsoft.Maui.Controls.SourceGen.CodeBehindGenerator/Resources_Styles_Styles.xaml.sg.cs(33): Trim analysis error IL2026: __XamlGeneratedCode__.__Type68A1B57D17E9473E.InitializeComponent(): Using member 'Microsoft.Maui.Controls.Xaml.OnPlatformExtension.Default.get' which has 'RequiresUnreferencedCodeAttribute' can break functionality when trimming application code. The OnPlatformExtension is not trim safe. Use OnPlatform<T> instead.
    /TrimWarning/obj/Release/net9.0-ios18.0/ios-arm64/Microsoft.Maui.Controls.SourceGen/Microsoft.Maui.Controls.SourceGen.CodeBehindGenerator/Resources_Styles_Styles.xaml.sg.cs(33): Trim analysis error IL2026: __XamlGeneratedCode__.__Type68A1B57D17E9473E.InitializeComponent(): Using member 'Microsoft.Maui.Controls.Xaml.OnPlatformExtension.Default.set' which has 'RequiresUnreferencedCodeAttribute' can break functionality when trimming application code. The OnPlatformExtension is not trim safe. Use OnPlatform<T> instead.
    /.nuget/packages/microsoft.dotnet.ilcompiler/9.0.0/build/Microsoft.NETCore.Native.targets(317,5): error MSB3073: The command ""/.nuget/packages/runtime.osx-arm64.microsoft.dotnet.ilcompiler/9.0.0/tools/ilc" @"obj/Release/net9.0-ios18.0/ios-arm64/native/Sentry.Samples.Maui.ilc.rsp"" exited with code -1.
```