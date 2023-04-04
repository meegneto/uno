#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.SmartCards
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SmartCardProvisioning 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.SmartCards.SmartCard SmartCard
		{
			get
			{
				throw new global::System.NotImplementedException("The member SmartCard SmartCardProvisioning.SmartCard is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SmartCard%20SmartCardProvisioning.SmartCard");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.SmartCards.SmartCardProvisioning.SmartCard.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Guid> GetIdAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Guid> SmartCardProvisioning.GetIdAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CGuid%3E%20SmartCardProvisioning.GetIdAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<string> GetNameAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> SmartCardProvisioning.GetNameAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20SmartCardProvisioning.GetNameAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.SmartCards.SmartCardChallengeContext> GetChallengeContextAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SmartCardChallengeContext> SmartCardProvisioning.GetChallengeContextAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CSmartCardChallengeContext%3E%20SmartCardProvisioning.GetChallengeContextAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> RequestPinChangeAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> SmartCardProvisioning.RequestPinChangeAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20SmartCardProvisioning.RequestPinChangeAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> RequestPinResetAsync( global::Windows.Devices.SmartCards.SmartCardPinResetHandler handler)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> SmartCardProvisioning.RequestPinResetAsync(SmartCardPinResetHandler handler) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20SmartCardProvisioning.RequestPinResetAsync%28SmartCardPinResetHandler%20handler%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<string> GetAuthorityKeyContainerNameAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> SmartCardProvisioning.GetAuthorityKeyContainerNameAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20SmartCardProvisioning.GetAuthorityKeyContainerNameAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.SmartCards.SmartCardProvisioning> RequestAttestedVirtualSmartCardCreationAsync( string friendlyName,  global::Windows.Storage.Streams.IBuffer administrativeKey,  global::Windows.Devices.SmartCards.SmartCardPinPolicy pinPolicy)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SmartCardProvisioning> SmartCardProvisioning.RequestAttestedVirtualSmartCardCreationAsync(string friendlyName, IBuffer administrativeKey, SmartCardPinPolicy pinPolicy) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CSmartCardProvisioning%3E%20SmartCardProvisioning.RequestAttestedVirtualSmartCardCreationAsync%28string%20friendlyName%2C%20IBuffer%20administrativeKey%2C%20SmartCardPinPolicy%20pinPolicy%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.SmartCards.SmartCardProvisioning> RequestAttestedVirtualSmartCardCreationAsync( string friendlyName,  global::Windows.Storage.Streams.IBuffer administrativeKey,  global::Windows.Devices.SmartCards.SmartCardPinPolicy pinPolicy,  global::System.Guid cardId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SmartCardProvisioning> SmartCardProvisioning.RequestAttestedVirtualSmartCardCreationAsync(string friendlyName, IBuffer administrativeKey, SmartCardPinPolicy pinPolicy, Guid cardId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CSmartCardProvisioning%3E%20SmartCardProvisioning.RequestAttestedVirtualSmartCardCreationAsync%28string%20friendlyName%2C%20IBuffer%20administrativeKey%2C%20SmartCardPinPolicy%20pinPolicy%2C%20Guid%20cardId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.SmartCards.SmartCardProvisioning> FromSmartCardAsync( global::Windows.Devices.SmartCards.SmartCard card)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SmartCardProvisioning> SmartCardProvisioning.FromSmartCardAsync(SmartCard card) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CSmartCardProvisioning%3E%20SmartCardProvisioning.FromSmartCardAsync%28SmartCard%20card%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.SmartCards.SmartCardProvisioning> RequestVirtualSmartCardCreationAsync( string friendlyName,  global::Windows.Storage.Streams.IBuffer administrativeKey,  global::Windows.Devices.SmartCards.SmartCardPinPolicy pinPolicy)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SmartCardProvisioning> SmartCardProvisioning.RequestVirtualSmartCardCreationAsync(string friendlyName, IBuffer administrativeKey, SmartCardPinPolicy pinPolicy) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CSmartCardProvisioning%3E%20SmartCardProvisioning.RequestVirtualSmartCardCreationAsync%28string%20friendlyName%2C%20IBuffer%20administrativeKey%2C%20SmartCardPinPolicy%20pinPolicy%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.SmartCards.SmartCardProvisioning> RequestVirtualSmartCardCreationAsync( string friendlyName,  global::Windows.Storage.Streams.IBuffer administrativeKey,  global::Windows.Devices.SmartCards.SmartCardPinPolicy pinPolicy,  global::System.Guid cardId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SmartCardProvisioning> SmartCardProvisioning.RequestVirtualSmartCardCreationAsync(string friendlyName, IBuffer administrativeKey, SmartCardPinPolicy pinPolicy, Guid cardId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CSmartCardProvisioning%3E%20SmartCardProvisioning.RequestVirtualSmartCardCreationAsync%28string%20friendlyName%2C%20IBuffer%20administrativeKey%2C%20SmartCardPinPolicy%20pinPolicy%2C%20Guid%20cardId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> RequestVirtualSmartCardDeletionAsync( global::Windows.Devices.SmartCards.SmartCard card)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> SmartCardProvisioning.RequestVirtualSmartCardDeletionAsync(SmartCard card) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20SmartCardProvisioning.RequestVirtualSmartCardDeletionAsync%28SmartCard%20card%29");
		}
		#endif
	}
}