#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RcsServiceKindSupportedChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Chat.RcsServiceKind ServiceKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member RcsServiceKind RcsServiceKindSupportedChangedEventArgs.ServiceKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=RcsServiceKind%20RcsServiceKindSupportedChangedEventArgs.ServiceKind");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.RcsServiceKindSupportedChangedEventArgs.ServiceKind.get
	}
}