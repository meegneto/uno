#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TileUpdateManagerForUser 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User TileUpdateManagerForUser.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=User%20TileUpdateManagerForUser.User");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Notifications.TileUpdater CreateTileUpdaterForApplicationForUser()
		{
			throw new global::System.NotImplementedException("The member TileUpdater TileUpdateManagerForUser.CreateTileUpdaterForApplicationForUser() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TileUpdater%20TileUpdateManagerForUser.CreateTileUpdaterForApplicationForUser%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Notifications.TileUpdater CreateTileUpdaterForApplication( string applicationId)
		{
			throw new global::System.NotImplementedException("The member TileUpdater TileUpdateManagerForUser.CreateTileUpdaterForApplication(string applicationId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TileUpdater%20TileUpdateManagerForUser.CreateTileUpdaterForApplication%28string%20applicationId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Notifications.TileUpdater CreateTileUpdaterForSecondaryTile( string tileId)
		{
			throw new global::System.NotImplementedException("The member TileUpdater TileUpdateManagerForUser.CreateTileUpdaterForSecondaryTile(string tileId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TileUpdater%20TileUpdateManagerForUser.CreateTileUpdaterForSecondaryTile%28string%20tileId%29");
		}
		#endif
		// Forced skipping of method Windows.UI.Notifications.TileUpdateManagerForUser.User.get
	}
}