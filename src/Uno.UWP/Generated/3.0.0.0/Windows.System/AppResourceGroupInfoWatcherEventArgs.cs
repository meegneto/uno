#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppResourceGroupInfoWatcherEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.System.AppDiagnosticInfo> AppDiagnosticInfos
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<AppDiagnosticInfo> AppResourceGroupInfoWatcherEventArgs.AppDiagnosticInfos is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CAppDiagnosticInfo%3E%20AppResourceGroupInfoWatcherEventArgs.AppDiagnosticInfos");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.AppResourceGroupInfo AppResourceGroupInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppResourceGroupInfo AppResourceGroupInfoWatcherEventArgs.AppResourceGroupInfo is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AppResourceGroupInfo%20AppResourceGroupInfoWatcherEventArgs.AppResourceGroupInfo");
			}
		}
		#endif
		// Forced skipping of method Windows.System.AppResourceGroupInfoWatcherEventArgs.AppDiagnosticInfos.get
		// Forced skipping of method Windows.System.AppResourceGroupInfoWatcherEventArgs.AppResourceGroupInfo.get
	}
}