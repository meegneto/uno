#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.UI
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebViewControlScriptNotifyEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri WebViewControlScriptNotifyEventArgs.Uri is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Uri%20WebViewControlScriptNotifyEventArgs.Uri");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebViewControlScriptNotifyEventArgs.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20WebViewControlScriptNotifyEventArgs.Value");
			}
		}
		#endif
		// Forced skipping of method Windows.Web.UI.WebViewControlScriptNotifyEventArgs.Uri.get
		// Forced skipping of method Windows.Web.UI.WebViewControlScriptNotifyEventArgs.Value.get
	}
}