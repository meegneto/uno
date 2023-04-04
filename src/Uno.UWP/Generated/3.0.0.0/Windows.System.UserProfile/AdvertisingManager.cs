#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.UserProfile
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class AdvertisingManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string AdvertisingId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AdvertisingManager.AdvertisingId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20AdvertisingManager.AdvertisingId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.UserProfile.AdvertisingManagerForUser GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member AdvertisingManagerForUser AdvertisingManager.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AdvertisingManagerForUser%20AdvertisingManager.GetForUser%28User%20user%29");
		}
		#endif
		// Forced skipping of method Windows.System.UserProfile.AdvertisingManager.AdvertisingId.get
	}
}