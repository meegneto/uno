#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Credentials
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class KeyCredentialManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> IsSupportedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> KeyCredentialManager.IsSupportedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20KeyCredentialManager.IsSupportedAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction RenewAttestationAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction KeyCredentialManager.RenewAttestationAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20KeyCredentialManager.RenewAttestationAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.KeyCredentialRetrievalResult> RequestCreateAsync( string name,  global::Windows.Security.Credentials.KeyCredentialCreationOption option)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<KeyCredentialRetrievalResult> KeyCredentialManager.RequestCreateAsync(string name, KeyCredentialCreationOption option) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CKeyCredentialRetrievalResult%3E%20KeyCredentialManager.RequestCreateAsync%28string%20name%2C%20KeyCredentialCreationOption%20option%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.KeyCredentialRetrievalResult> OpenAsync( string name)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<KeyCredentialRetrievalResult> KeyCredentialManager.OpenAsync(string name) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CKeyCredentialRetrievalResult%3E%20KeyCredentialManager.OpenAsync%28string%20name%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction DeleteAsync( string name)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction KeyCredentialManager.DeleteAsync(string name) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20KeyCredentialManager.DeleteAsync%28string%20name%29");
		}
		#endif
	}
}