#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ServerMessageWebSocketInformation 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Sockets.BandwidthStatistics BandwidthStatistics
		{
			get
			{
				throw new global::System.NotImplementedException("The member BandwidthStatistics ServerMessageWebSocketInformation.BandwidthStatistics is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BandwidthStatistics%20ServerMessageWebSocketInformation.BandwidthStatistics");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.HostName LocalAddress
		{
			get
			{
				throw new global::System.NotImplementedException("The member HostName ServerMessageWebSocketInformation.LocalAddress is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=HostName%20ServerMessageWebSocketInformation.LocalAddress");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Protocol
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ServerMessageWebSocketInformation.Protocol is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ServerMessageWebSocketInformation.Protocol");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Sockets.ServerMessageWebSocketInformation.BandwidthStatistics.get
		// Forced skipping of method Windows.Networking.Sockets.ServerMessageWebSocketInformation.Protocol.get
		// Forced skipping of method Windows.Networking.Sockets.ServerMessageWebSocketInformation.LocalAddress.get
	}
}