---
uid: Uno.Development.UwpVsWinUI3
---

# WinUI 3 and Uno Platform

WinUI 3 is the [next generation of Microsoft's Windows UI library](https://docs.microsoft.com/windows/apps/winui/). It succeeds the UWP XAML framework as Microsoft's actively-developed native UI platform for Windows. WinUI 3 supports Windows Desktop apps through [Windows AppSDK](https://docs.microsoft.com/windows/apps/windows-app-sdk/).

Since WinUI 3 and UWP XAML are very similar in their API, Uno Platform offers compatibility with both. This article goes further into the differences and how they apply to Uno.

> [!TIP]
> If you just want to add WinUI controls to your Uno Platform project, [check the guide here](features/using-winui2.md).

## How does WinUI 3 differ from UWP XAML?

WinUI 3 differs in minor ways from UWP XAML in terms of API, and in more substantial ways in its technical comportment.

### API

The chief difference between WinUI 3 and UWP XAML is the change of namespace. UWP XAML namespaces begin with 'Windows' - `Windows.UI.Xaml`, `Windows.UI.Composition`, and so on. WinUI 3 namespaces begin with 'Microsoft' - `Microsoft.UI.Xaml`, `Microsoft.UI.Composition` and so on. Aside from that change, the API surface is very similar. Some of the remaining differences are listed in our [guide to upgrading to WinUI 3](updating-to-winui3.md).

### Technical

Below the surface, the differences are more substantial. The UWP XAML stack is part of the Windows OS. The WinUI 3 stack is decoupled from the OS. This means application developers can use the newest features without worrying that they might not be supported on the end user's system.

WinUI 3 is also decoupled from the application model. The UWP XAML stack is only compatible with the 'UWP model' in which the application runs in a secure sandbox. WinUI 3 is compatible both with the 'UWP model' and with the traditional 'Win32' or 'desktop' application model in which the application has largely-unrestricted access to the rest of the OS. 

## How does this affect Uno Platform?

Uno Platform is only affected by the API change - the technical changes don't apply on non-Windows platforms.

When you create a new Uno Platform application, you can choose to create a WinUI 3-compatible application (using the WinUI 3 API, and building with WinUI 3 on the Windows head project) instead of a UWP XAML-compatible application [using the `dotnet new` templates](get-started-dotnet-new.md#uno-platform-blank-application-for-winappsdk---winui-3). 

This is possible because we ship two sets of the `Uno.UI` binaries, [one set](https://www.nuget.org/packages/Uno.UI/) that is compatible with UWP XAML, and a [second set](https://www.nuget.org/packages/Uno.WinUI/) that is compatible with WinUI 3. The WinUI 3-compatible binaries are generated by an automated transformation step, so the runtime behavior is nearly identical for a given version number, and neither set lags behind the other in terms of releases.

## Should I use WinUI 3 or UWP XAML with Uno Platform?

The questions below should help guide you to the best choice when creating a new Uno Platform application. Note that WinUI 3 is nearing release and some of the guidance here may change or become outdated rather rapidly.

#### Do you use 3rd-party libraries?

While 3rd party vendors have offerings for both UWP and WinUI, UWP has been in the market longer. From Uno Platform perspective either will work, or if not, contact us at our [Discord channel](https://discord.com/invite/eBHZSKG).

#### Do you want to use .NET 5 or 6?

WinUI 3 applications using the Win32 application model can use .NET 5 and latest C# versions right now. Microsoft has announced they will not invest into moving UWP to .NET 5 or later. However, this does not change anything for Uno Platform users, as described in this [blog](https://platform.uno/blog/recent-uwp-and-net-5-net-6-news-and-uno-platform-plans/).

Note that not all non-Windows platforms support .NET 5, see a [full support matrix here](net-version-support.md).

#### Do you plan to publish on Windows?

If Windows is one of your target platforms, then the [technical differences](#technical) discussed above apply. Probably the key question is, can your application run in the sandboxed 'UWP model', or is it better served by the unrestricted 'Win32 model'?

#### Do you depend on features that aren't yet migrated to WinUI 3?

[Check the WinUI 3 roadmap](https://github.com/microsoft/microsoft-ui-xaml/blob/master/docs/roadmap.md#winui-30-feature-roadmap) for a list of features that won't be available in the initial supported release, like `InkCanvas`.

## Further reading

 * [Create a new WinUI 3-flavored Uno Platform app with Project Reunion support](get-started-winui3.md)
 * [Migrate an existing Uno Platform app to WinUI 3](updating-to-winui3.md)