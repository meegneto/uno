#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class SocketError 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Networking.Sockets.SocketErrorStatus GetStatus( int hresult)
		{
			throw new global::System.NotImplementedException("The member SocketErrorStatus SocketError.GetStatus(int hresult) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SocketErrorStatus%20SocketError.GetStatus%28int%20hresult%29");
		}
		#endif
	}
}