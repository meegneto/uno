#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Enumeration
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DeviceInformationPairing 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanPair
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DeviceInformationPairing.CanPair is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20DeviceInformationPairing.CanPair");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsPaired
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DeviceInformationPairing.IsPaired is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20DeviceInformationPairing.IsPaired");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Enumeration.DeviceInformationCustomPairing Custom
		{
			get
			{
				throw new global::System.NotImplementedException("The member DeviceInformationCustomPairing DeviceInformationPairing.Custom is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DeviceInformationCustomPairing%20DeviceInformationPairing.Custom");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Enumeration.DevicePairingProtectionLevel ProtectionLevel
		{
			get
			{
				throw new global::System.NotImplementedException("The member DevicePairingProtectionLevel DeviceInformationPairing.ProtectionLevel is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DevicePairingProtectionLevel%20DeviceInformationPairing.ProtectionLevel");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Enumeration.DeviceInformationPairing.IsPaired.get
		// Forced skipping of method Windows.Devices.Enumeration.DeviceInformationPairing.CanPair.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Enumeration.DevicePairingResult> PairAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DevicePairingResult> DeviceInformationPairing.PairAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CDevicePairingResult%3E%20DeviceInformationPairing.PairAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Enumeration.DevicePairingResult> PairAsync( global::Windows.Devices.Enumeration.DevicePairingProtectionLevel minProtectionLevel)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DevicePairingResult> DeviceInformationPairing.PairAsync(DevicePairingProtectionLevel minProtectionLevel) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CDevicePairingResult%3E%20DeviceInformationPairing.PairAsync%28DevicePairingProtectionLevel%20minProtectionLevel%29");
		}
		#endif
		// Forced skipping of method Windows.Devices.Enumeration.DeviceInformationPairing.ProtectionLevel.get
		// Forced skipping of method Windows.Devices.Enumeration.DeviceInformationPairing.Custom.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Enumeration.DevicePairingResult> PairAsync( global::Windows.Devices.Enumeration.DevicePairingProtectionLevel minProtectionLevel,  global::Windows.Devices.Enumeration.IDevicePairingSettings devicePairingSettings)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DevicePairingResult> DeviceInformationPairing.PairAsync(DevicePairingProtectionLevel minProtectionLevel, IDevicePairingSettings devicePairingSettings) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CDevicePairingResult%3E%20DeviceInformationPairing.PairAsync%28DevicePairingProtectionLevel%20minProtectionLevel%2C%20IDevicePairingSettings%20devicePairingSettings%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Enumeration.DeviceUnpairingResult> UnpairAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DeviceUnpairingResult> DeviceInformationPairing.UnpairAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CDeviceUnpairingResult%3E%20DeviceInformationPairing.UnpairAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryRegisterForAllInboundPairingRequestsWithProtectionLevel( global::Windows.Devices.Enumeration.DevicePairingKinds pairingKindsSupported,  global::Windows.Devices.Enumeration.DevicePairingProtectionLevel minProtectionLevel)
		{
			throw new global::System.NotImplementedException("The member bool DeviceInformationPairing.TryRegisterForAllInboundPairingRequestsWithProtectionLevel(DevicePairingKinds pairingKindsSupported, DevicePairingProtectionLevel minProtectionLevel) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20DeviceInformationPairing.TryRegisterForAllInboundPairingRequestsWithProtectionLevel%28DevicePairingKinds%20pairingKindsSupported%2C%20DevicePairingProtectionLevel%20minProtectionLevel%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryRegisterForAllInboundPairingRequests( global::Windows.Devices.Enumeration.DevicePairingKinds pairingKindsSupported)
		{
			throw new global::System.NotImplementedException("The member bool DeviceInformationPairing.TryRegisterForAllInboundPairingRequests(DevicePairingKinds pairingKindsSupported) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20DeviceInformationPairing.TryRegisterForAllInboundPairingRequests%28DevicePairingKinds%20pairingKindsSupported%29");
		}
		#endif
	}
}