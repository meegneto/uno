#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.UI
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebViewControlDOMContentLoadedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri WebViewControlDOMContentLoadedEventArgs.Uri is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Uri%20WebViewControlDOMContentLoadedEventArgs.Uri");
			}
		}
		#endif
		// Forced skipping of method Windows.Web.UI.WebViewControlDOMContentLoadedEventArgs.Uri.get
	}
}