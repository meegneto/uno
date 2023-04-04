#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class TileUpdateManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Notifications.TileUpdateManagerForUser GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member TileUpdateManagerForUser TileUpdateManager.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TileUpdateManagerForUser%20TileUpdateManager.GetForUser%28User%20user%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Notifications.TileUpdater CreateTileUpdaterForApplication()
		{
			throw new global::System.NotImplementedException("The member TileUpdater TileUpdateManager.CreateTileUpdaterForApplication() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TileUpdater%20TileUpdateManager.CreateTileUpdaterForApplication%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Notifications.TileUpdater CreateTileUpdaterForApplication( string applicationId)
		{
			throw new global::System.NotImplementedException("The member TileUpdater TileUpdateManager.CreateTileUpdaterForApplication(string applicationId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TileUpdater%20TileUpdateManager.CreateTileUpdaterForApplication%28string%20applicationId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Notifications.TileUpdater CreateTileUpdaterForSecondaryTile( string tileId)
		{
			throw new global::System.NotImplementedException("The member TileUpdater TileUpdateManager.CreateTileUpdaterForSecondaryTile(string tileId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TileUpdater%20TileUpdateManager.CreateTileUpdaterForSecondaryTile%28string%20tileId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Data.Xml.Dom.XmlDocument GetTemplateContent( global::Windows.UI.Notifications.TileTemplateType type)
		{
			throw new global::System.NotImplementedException("The member XmlDocument TileUpdateManager.GetTemplateContent(TileTemplateType type) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=XmlDocument%20TileUpdateManager.GetTemplateContent%28TileTemplateType%20type%29");
		}
		#endif
	}
}