#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Store
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class CurrentAppSimulator 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Guid AppId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid CurrentAppSimulator.AppId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Guid%20CurrentAppSimulator.AppId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Store.LicenseInformation LicenseInformation
		{
			get
			{
				throw new global::System.NotImplementedException("The member LicenseInformation CurrentAppSimulator.LicenseInformation is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=LicenseInformation%20CurrentAppSimulator.LicenseInformation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Uri LinkUri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri CurrentAppSimulator.LinkUri is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Uri%20CurrentAppSimulator.LinkUri");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> GetAppPurchaseCampaignIdAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentAppSimulator.GetAppPurchaseCampaignIdAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentAppSimulator.GetAppPurchaseCampaignIdAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationByProductIdsAsync( global::System.Collections.Generic.IEnumerable<string> productIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ListingInformation> CurrentAppSimulator.LoadListingInformationByProductIdsAsync(IEnumerable<string> productIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CListingInformation%3E%20CurrentAppSimulator.LoadListingInformationByProductIdsAsync%28IEnumerable%3Cstring%3E%20productIds%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationByKeywordsAsync( global::System.Collections.Generic.IEnumerable<string> keywords)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ListingInformation> CurrentAppSimulator.LoadListingInformationByKeywordsAsync(IEnumerable<string> keywords) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CListingInformation%3E%20CurrentAppSimulator.LoadListingInformationByKeywordsAsync%28IEnumerable%3Cstring%3E%20keywords%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.FulfillmentResult> ReportConsumableFulfillmentAsync( string productId,  global::System.Guid transactionId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<FulfillmentResult> CurrentAppSimulator.ReportConsumableFulfillmentAsync(string productId, Guid transactionId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CFulfillmentResult%3E%20CurrentAppSimulator.ReportConsumableFulfillmentAsync%28string%20productId%2C%20Guid%20transactionId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync( string productId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PurchaseResults> CurrentAppSimulator.RequestProductPurchaseAsync(string productId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CPurchaseResults%3E%20CurrentAppSimulator.RequestProductPurchaseAsync%28string%20productId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync( string productId,  string offerId,  global::Windows.ApplicationModel.Store.ProductPurchaseDisplayProperties displayProperties)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PurchaseResults> CurrentAppSimulator.RequestProductPurchaseAsync(string productId, string offerId, ProductPurchaseDisplayProperties displayProperties) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CPurchaseResults%3E%20CurrentAppSimulator.RequestProductPurchaseAsync%28string%20productId%2C%20string%20offerId%2C%20ProductPurchaseDisplayProperties%20displayProperties%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Store.UnfulfilledConsumable>> GetUnfulfilledConsumablesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<UnfulfilledConsumable>> CurrentAppSimulator.GetUnfulfilledConsumablesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CUnfulfilledConsumable%3E%3E%20CurrentAppSimulator.GetUnfulfilledConsumablesAsync%28%29");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Store.CurrentAppSimulator.LicenseInformation.get
		// Forced skipping of method Windows.ApplicationModel.Store.CurrentAppSimulator.LinkUri.get
		// Forced skipping of method Windows.ApplicationModel.Store.CurrentAppSimulator.AppId.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> RequestAppPurchaseAsync( bool includeReceipt)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentAppSimulator.RequestAppPurchaseAsync(bool includeReceipt) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentAppSimulator.RequestAppPurchaseAsync%28bool%20includeReceipt%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> RequestProductPurchaseAsync( string productId,  bool includeReceipt)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentAppSimulator.RequestProductPurchaseAsync(string productId, bool includeReceipt) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentAppSimulator.RequestProductPurchaseAsync%28string%20productId%2C%20bool%20includeReceipt%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ListingInformation> CurrentAppSimulator.LoadListingInformationAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CListingInformation%3E%20CurrentAppSimulator.LoadListingInformationAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> GetAppReceiptAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentAppSimulator.GetAppReceiptAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentAppSimulator.GetAppReceiptAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> GetProductReceiptAsync( string productId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentAppSimulator.GetProductReceiptAsync(string productId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentAppSimulator.GetProductReceiptAsync%28string%20productId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction ReloadSimulatorAsync( global::Windows.Storage.StorageFile simulatorSettingsFile)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction CurrentAppSimulator.ReloadSimulatorAsync(StorageFile simulatorSettingsFile) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20CurrentAppSimulator.ReloadSimulatorAsync%28StorageFile%20simulatorSettingsFile%29");
		}
		#endif
	}
}