#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactAnnotationList 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ContactAnnotationList.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ContactAnnotationList.Id");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ProviderPackageFamilyName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ContactAnnotationList.ProviderPackageFamilyName is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ContactAnnotationList.ProviderPackageFamilyName");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string UserDataAccountId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ContactAnnotationList.UserDataAccountId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ContactAnnotationList.UserDataAccountId");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactAnnotationList.Id.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactAnnotationList.ProviderPackageFamilyName.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactAnnotationList.UserDataAccountId.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DeleteAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContactAnnotationList.DeleteAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ContactAnnotationList.DeleteAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> TrySaveAnnotationAsync( global::Windows.ApplicationModel.Contacts.ContactAnnotation annotation)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ContactAnnotationList.TrySaveAnnotationAsync(ContactAnnotation annotation) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20ContactAnnotationList.TrySaveAnnotationAsync%28ContactAnnotation%20annotation%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactAnnotation> GetAnnotationAsync( string annotationId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactAnnotation> ContactAnnotationList.GetAnnotationAsync(string annotationId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CContactAnnotation%3E%20ContactAnnotationList.GetAnnotationAsync%28string%20annotationId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.ContactAnnotation>> FindAnnotationsByRemoteIdAsync( string remoteId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ContactAnnotation>> ContactAnnotationList.FindAnnotationsByRemoteIdAsync(string remoteId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CContactAnnotation%3E%3E%20ContactAnnotationList.FindAnnotationsByRemoteIdAsync%28string%20remoteId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.ContactAnnotation>> FindAnnotationsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ContactAnnotation>> ContactAnnotationList.FindAnnotationsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CContactAnnotation%3E%3E%20ContactAnnotationList.FindAnnotationsAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DeleteAnnotationAsync( global::Windows.ApplicationModel.Contacts.ContactAnnotation annotation)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContactAnnotationList.DeleteAnnotationAsync(ContactAnnotation annotation) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ContactAnnotationList.DeleteAnnotationAsync%28ContactAnnotation%20annotation%29");
		}
		#endif
	}
}