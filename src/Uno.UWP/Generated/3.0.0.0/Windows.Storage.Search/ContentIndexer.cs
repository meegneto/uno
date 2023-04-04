#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Search
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContentIndexer 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong Revision
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong ContentIndexer.Revision is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ulong%20ContentIndexer.Revision");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction AddAsync( global::Windows.Storage.Search.IIndexableContent indexableContent)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContentIndexer.AddAsync(IIndexableContent indexableContent) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ContentIndexer.AddAsync%28IIndexableContent%20indexableContent%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction UpdateAsync( global::Windows.Storage.Search.IIndexableContent indexableContent)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContentIndexer.UpdateAsync(IIndexableContent indexableContent) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ContentIndexer.UpdateAsync%28IIndexableContent%20indexableContent%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DeleteAsync( string contentId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContentIndexer.DeleteAsync(string contentId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ContentIndexer.DeleteAsync%28string%20contentId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DeleteMultipleAsync( global::System.Collections.Generic.IEnumerable<string> contentIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContentIndexer.DeleteMultipleAsync(IEnumerable<string> contentIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ContentIndexer.DeleteMultipleAsync%28IEnumerable%3Cstring%3E%20contentIds%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DeleteAllAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContentIndexer.DeleteAllAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ContentIndexer.DeleteAllAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyDictionary<string, object>> RetrievePropertiesAsync( string contentId,  global::System.Collections.Generic.IEnumerable<string> propertiesToRetrieve)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyDictionary<string, object>> ContentIndexer.RetrievePropertiesAsync(string contentId, IEnumerable<string> propertiesToRetrieve) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyDictionary%3Cstring%2C%20object%3E%3E%20ContentIndexer.RetrievePropertiesAsync%28string%20contentId%2C%20IEnumerable%3Cstring%3E%20propertiesToRetrieve%29");
		}
		#endif
		// Forced skipping of method Windows.Storage.Search.ContentIndexer.Revision.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Search.ContentIndexerQuery CreateQuery( string searchFilter,  global::System.Collections.Generic.IEnumerable<string> propertiesToRetrieve,  global::System.Collections.Generic.IEnumerable<global::Windows.Storage.Search.SortEntry> sortOrder,  string searchFilterLanguage)
		{
			throw new global::System.NotImplementedException("The member ContentIndexerQuery ContentIndexer.CreateQuery(string searchFilter, IEnumerable<string> propertiesToRetrieve, IEnumerable<SortEntry> sortOrder, string searchFilterLanguage) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContentIndexerQuery%20ContentIndexer.CreateQuery%28string%20searchFilter%2C%20IEnumerable%3Cstring%3E%20propertiesToRetrieve%2C%20IEnumerable%3CSortEntry%3E%20sortOrder%2C%20string%20searchFilterLanguage%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Search.ContentIndexerQuery CreateQuery( string searchFilter,  global::System.Collections.Generic.IEnumerable<string> propertiesToRetrieve,  global::System.Collections.Generic.IEnumerable<global::Windows.Storage.Search.SortEntry> sortOrder)
		{
			throw new global::System.NotImplementedException("The member ContentIndexerQuery ContentIndexer.CreateQuery(string searchFilter, IEnumerable<string> propertiesToRetrieve, IEnumerable<SortEntry> sortOrder) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContentIndexerQuery%20ContentIndexer.CreateQuery%28string%20searchFilter%2C%20IEnumerable%3Cstring%3E%20propertiesToRetrieve%2C%20IEnumerable%3CSortEntry%3E%20sortOrder%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Search.ContentIndexerQuery CreateQuery( string searchFilter,  global::System.Collections.Generic.IEnumerable<string> propertiesToRetrieve)
		{
			throw new global::System.NotImplementedException("The member ContentIndexerQuery ContentIndexer.CreateQuery(string searchFilter, IEnumerable<string> propertiesToRetrieve) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContentIndexerQuery%20ContentIndexer.CreateQuery%28string%20searchFilter%2C%20IEnumerable%3Cstring%3E%20propertiesToRetrieve%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.Search.ContentIndexer GetIndexer( string indexName)
		{
			throw new global::System.NotImplementedException("The member ContentIndexer ContentIndexer.GetIndexer(string indexName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContentIndexer%20ContentIndexer.GetIndexer%28string%20indexName%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.Search.ContentIndexer GetIndexer()
		{
			throw new global::System.NotImplementedException("The member ContentIndexer ContentIndexer.GetIndexer() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContentIndexer%20ContentIndexer.GetIndexer%28%29");
		}
		#endif
	}
}