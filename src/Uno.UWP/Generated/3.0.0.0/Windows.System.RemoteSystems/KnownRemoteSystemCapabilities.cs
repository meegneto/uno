#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class KnownRemoteSystemCapabilities 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string AppService
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownRemoteSystemCapabilities.AppService is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KnownRemoteSystemCapabilities.AppService");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string LaunchUri
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownRemoteSystemCapabilities.LaunchUri is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KnownRemoteSystemCapabilities.LaunchUri");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string RemoteSession
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownRemoteSystemCapabilities.RemoteSession is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KnownRemoteSystemCapabilities.RemoteSession");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string SpatialEntity
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownRemoteSystemCapabilities.SpatialEntity is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KnownRemoteSystemCapabilities.SpatialEntity");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.KnownRemoteSystemCapabilities.AppService.get
		// Forced skipping of method Windows.System.RemoteSystems.KnownRemoteSystemCapabilities.LaunchUri.get
		// Forced skipping of method Windows.System.RemoteSystems.KnownRemoteSystemCapabilities.RemoteSession.get
		// Forced skipping of method Windows.System.RemoteSystems.KnownRemoteSystemCapabilities.SpatialEntity.get
	}
}