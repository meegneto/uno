#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextCompositionEndedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int Length
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextCompositionEndedEventArgs.Length is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20TextCompositionEndedEventArgs.Length");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int StartIndex
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextCompositionEndedEventArgs.StartIndex is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20TextCompositionEndedEventArgs.StartIndex");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs.StartIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs.Length.get
	}
}