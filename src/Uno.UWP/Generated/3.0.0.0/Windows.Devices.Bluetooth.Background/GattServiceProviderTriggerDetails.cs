#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.Background
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GattServiceProviderTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Bluetooth.Background.GattServiceProviderConnection Connection
		{
			get
			{
				throw new global::System.NotImplementedException("The member GattServiceProviderConnection GattServiceProviderTriggerDetails.Connection is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=GattServiceProviderConnection%20GattServiceProviderTriggerDetails.Connection");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.Background.GattServiceProviderTriggerDetails.Connection.get
	}
}