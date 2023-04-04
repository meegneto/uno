#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Credentials
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class KeyCredential 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KeyCredential.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KeyCredential.Name");
			}
		}
		#endif
		// Forced skipping of method Windows.Security.Credentials.KeyCredential.Name.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer RetrievePublicKey()
		{
			throw new global::System.NotImplementedException("The member IBuffer KeyCredential.RetrievePublicKey() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IBuffer%20KeyCredential.RetrievePublicKey%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer RetrievePublicKey( global::Windows.Security.Cryptography.Core.CryptographicPublicKeyBlobType blobType)
		{
			throw new global::System.NotImplementedException("The member IBuffer KeyCredential.RetrievePublicKey(CryptographicPublicKeyBlobType blobType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IBuffer%20KeyCredential.RetrievePublicKey%28CryptographicPublicKeyBlobType%20blobType%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.KeyCredentialOperationResult> RequestSignAsync( global::Windows.Storage.Streams.IBuffer data)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<KeyCredentialOperationResult> KeyCredential.RequestSignAsync(IBuffer data) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CKeyCredentialOperationResult%3E%20KeyCredential.RequestSignAsync%28IBuffer%20data%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.KeyCredentialAttestationResult> GetAttestationAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<KeyCredentialAttestationResult> KeyCredential.GetAttestationAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CKeyCredentialAttestationResult%3E%20KeyCredential.GetAttestationAsync%28%29");
		}
		#endif
	}
}