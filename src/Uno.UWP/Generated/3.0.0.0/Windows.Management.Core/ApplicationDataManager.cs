#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Management.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ApplicationDataManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.ApplicationData CreateForPackageFamily( string packageFamilyName)
		{
			throw new global::System.NotImplementedException("The member ApplicationData ApplicationDataManager.CreateForPackageFamily(string packageFamilyName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ApplicationData%20ApplicationDataManager.CreateForPackageFamily%28string%20packageFamilyName%29");
		}
		#endif
	}
}