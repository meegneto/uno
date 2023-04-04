#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Web.Provider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class WebAccountManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction InvalidateAppCacheForAllAccountsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.InvalidateAppCacheForAllAccountsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.InvalidateAppCacheForAllAccountsAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction InvalidateAppCacheForAccountAsync( global::Windows.Security.Credentials.WebAccount webAccount)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.InvalidateAppCacheForAccountAsync(WebAccount webAccount) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.InvalidateAppCacheForAccountAsync%28WebAccount%20webAccount%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Credentials.WebAccount>> FindAllProviderWebAccountsForUserAsync( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<WebAccount>> WebAccountManager.FindAllProviderWebAccountsForUserAsync(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CWebAccount%3E%3E%20WebAccountManager.FindAllProviderWebAccountsForUserAsync%28User%20user%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.WebAccount> AddWebAccountForUserAsync( global::Windows.System.User user,  string webAccountId,  string webAccountUserName,  global::System.Collections.Generic.IReadOnlyDictionary<string, string> props)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WebAccount> WebAccountManager.AddWebAccountForUserAsync(User user, string webAccountId, string webAccountUserName, IReadOnlyDictionary<string, string> props) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWebAccount%3E%20WebAccountManager.AddWebAccountForUserAsync%28User%20user%2C%20string%20webAccountId%2C%20string%20webAccountUserName%2C%20IReadOnlyDictionary%3Cstring%2C%20string%3E%20props%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.WebAccount> AddWebAccountForUserAsync( global::Windows.System.User user,  string webAccountId,  string webAccountUserName,  global::System.Collections.Generic.IReadOnlyDictionary<string, string> props,  global::Windows.Security.Authentication.Web.Provider.WebAccountScope scope)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WebAccount> WebAccountManager.AddWebAccountForUserAsync(User user, string webAccountId, string webAccountUserName, IReadOnlyDictionary<string, string> props, WebAccountScope scope) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWebAccount%3E%20WebAccountManager.AddWebAccountForUserAsync%28User%20user%2C%20string%20webAccountId%2C%20string%20webAccountUserName%2C%20IReadOnlyDictionary%3Cstring%2C%20string%3E%20props%2C%20WebAccountScope%20scope%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.WebAccount> AddWebAccountForUserAsync( global::Windows.System.User user,  string webAccountId,  string webAccountUserName,  global::System.Collections.Generic.IReadOnlyDictionary<string, string> props,  global::Windows.Security.Authentication.Web.Provider.WebAccountScope scope,  string perUserWebAccountId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WebAccount> WebAccountManager.AddWebAccountForUserAsync(User user, string webAccountId, string webAccountUserName, IReadOnlyDictionary<string, string> props, WebAccountScope scope, string perUserWebAccountId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWebAccount%3E%20WebAccountManager.AddWebAccountForUserAsync%28User%20user%2C%20string%20webAccountId%2C%20string%20webAccountUserName%2C%20IReadOnlyDictionary%3Cstring%2C%20string%3E%20props%2C%20WebAccountScope%20scope%2C%20string%20perUserWebAccountId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.WebAccount> AddWebAccountAsync( string webAccountId,  string webAccountUserName,  global::System.Collections.Generic.IReadOnlyDictionary<string, string> props,  global::Windows.Security.Authentication.Web.Provider.WebAccountScope scope,  string perUserWebAccountId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WebAccount> WebAccountManager.AddWebAccountAsync(string webAccountId, string webAccountUserName, IReadOnlyDictionary<string, string> props, WebAccountScope scope, string perUserWebAccountId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWebAccount%3E%20WebAccountManager.AddWebAccountAsync%28string%20webAccountId%2C%20string%20webAccountUserName%2C%20IReadOnlyDictionary%3Cstring%2C%20string%3E%20props%2C%20WebAccountScope%20scope%2C%20string%20perUserWebAccountId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SetPerAppToPerUserAccountAsync( global::Windows.Security.Credentials.WebAccount perAppAccount,  string perUserWebAccountId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.SetPerAppToPerUserAccountAsync(WebAccount perAppAccount, string perUserWebAccountId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.SetPerAppToPerUserAccountAsync%28WebAccount%20perAppAccount%2C%20string%20perUserWebAccountId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.WebAccount> GetPerUserFromPerAppAccountAsync( global::Windows.Security.Credentials.WebAccount perAppAccount)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WebAccount> WebAccountManager.GetPerUserFromPerAppAccountAsync(WebAccount perAppAccount) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWebAccount%3E%20WebAccountManager.GetPerUserFromPerAppAccountAsync%28WebAccount%20perAppAccount%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction ClearPerUserFromPerAppAccountAsync( global::Windows.Security.Credentials.WebAccount perAppAccount)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.ClearPerUserFromPerAppAccountAsync(WebAccount perAppAccount) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.ClearPerUserFromPerAppAccountAsync%28WebAccount%20perAppAccount%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.WebAccount> AddWebAccountAsync( string webAccountId,  string webAccountUserName,  global::System.Collections.Generic.IReadOnlyDictionary<string, string> props,  global::Windows.Security.Authentication.Web.Provider.WebAccountScope scope)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WebAccount> WebAccountManager.AddWebAccountAsync(string webAccountId, string webAccountUserName, IReadOnlyDictionary<string, string> props, WebAccountScope scope) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWebAccount%3E%20WebAccountManager.AddWebAccountAsync%28string%20webAccountId%2C%20string%20webAccountUserName%2C%20IReadOnlyDictionary%3Cstring%2C%20string%3E%20props%2C%20WebAccountScope%20scope%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SetScopeAsync( global::Windows.Security.Credentials.WebAccount webAccount,  global::Windows.Security.Authentication.Web.Provider.WebAccountScope scope)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.SetScopeAsync(WebAccount webAccount, WebAccountScope scope) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.SetScopeAsync%28WebAccount%20webAccount%2C%20WebAccountScope%20scope%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Security.Authentication.Web.Provider.WebAccountScope GetScope( global::Windows.Security.Credentials.WebAccount webAccount)
		{
			throw new global::System.NotImplementedException("The member WebAccountScope WebAccountManager.GetScope(WebAccount webAccount) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=WebAccountScope%20WebAccountManager.GetScope%28WebAccount%20webAccount%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction PullCookiesAsync( string uriString,  string callerPFN)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.PullCookiesAsync(string uriString, string callerPFN) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.PullCookiesAsync%28string%20uriString%2C%20string%20callerPFN%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction UpdateWebAccountPropertiesAsync( global::Windows.Security.Credentials.WebAccount webAccount,  string webAccountUserName,  global::System.Collections.Generic.IReadOnlyDictionary<string, string> additionalProperties)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.UpdateWebAccountPropertiesAsync(WebAccount webAccount, string webAccountUserName, IReadOnlyDictionary<string, string> additionalProperties) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.UpdateWebAccountPropertiesAsync%28WebAccount%20webAccount%2C%20string%20webAccountUserName%2C%20IReadOnlyDictionary%3Cstring%2C%20string%3E%20additionalProperties%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Credentials.WebAccount> AddWebAccountAsync( string webAccountId,  string webAccountUserName,  global::System.Collections.Generic.IReadOnlyDictionary<string, string> props)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WebAccount> WebAccountManager.AddWebAccountAsync(string webAccountId, string webAccountUserName, IReadOnlyDictionary<string, string> props) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWebAccount%3E%20WebAccountManager.AddWebAccountAsync%28string%20webAccountId%2C%20string%20webAccountUserName%2C%20IReadOnlyDictionary%3Cstring%2C%20string%3E%20props%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction DeleteWebAccountAsync( global::Windows.Security.Credentials.WebAccount webAccount)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.DeleteWebAccountAsync(WebAccount webAccount) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.DeleteWebAccountAsync%28WebAccount%20webAccount%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Credentials.WebAccount>> FindAllProviderWebAccountsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<WebAccount>> WebAccountManager.FindAllProviderWebAccountsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CWebAccount%3E%3E%20WebAccountManager.FindAllProviderWebAccountsAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction PushCookiesAsync( global::System.Uri uri,  global::System.Collections.Generic.IReadOnlyList<global::Windows.Web.Http.HttpCookie> cookies)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.PushCookiesAsync(Uri uri, IReadOnlyList<HttpCookie> cookies) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.PushCookiesAsync%28Uri%20uri%2C%20IReadOnlyList%3CHttpCookie%3E%20cookies%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SetViewAsync( global::Windows.Security.Credentials.WebAccount webAccount,  global::Windows.Security.Authentication.Web.Provider.WebAccountClientView view)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.SetViewAsync(WebAccount webAccount, WebAccountClientView view) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.SetViewAsync%28WebAccount%20webAccount%2C%20WebAccountClientView%20view%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction ClearViewAsync( global::Windows.Security.Credentials.WebAccount webAccount,  global::System.Uri applicationCallbackUri)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.ClearViewAsync(WebAccount webAccount, Uri applicationCallbackUri) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.ClearViewAsync%28WebAccount%20webAccount%2C%20Uri%20applicationCallbackUri%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Authentication.Web.Provider.WebAccountClientView>> GetViewsAsync( global::Windows.Security.Credentials.WebAccount webAccount)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<WebAccountClientView>> WebAccountManager.GetViewsAsync(WebAccount webAccount) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CWebAccountClientView%3E%3E%20WebAccountManager.GetViewsAsync%28WebAccount%20webAccount%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SetWebAccountPictureAsync( global::Windows.Security.Credentials.WebAccount webAccount,  global::Windows.Storage.Streams.IRandomAccessStream webAccountPicture)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.SetWebAccountPictureAsync(WebAccount webAccount, IRandomAccessStream webAccountPicture) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.SetWebAccountPictureAsync%28WebAccount%20webAccount%2C%20IRandomAccessStream%20webAccountPicture%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction ClearWebAccountPictureAsync( global::Windows.Security.Credentials.WebAccount webAccount)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebAccountManager.ClearWebAccountPictureAsync(WebAccount webAccount) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20WebAccountManager.ClearWebAccountPictureAsync%28WebAccount%20webAccount%29");
		}
		#endif
	}
}