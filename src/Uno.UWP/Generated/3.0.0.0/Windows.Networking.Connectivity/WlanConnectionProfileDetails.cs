#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WlanConnectionProfileDetails 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string GetConnectedSsid()
		{
			throw new global::System.NotImplementedException("The member string WlanConnectionProfileDetails.GetConnectedSsid() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20WlanConnectionProfileDetails.GetConnectedSsid%28%29");
		}
		#endif
	}
}