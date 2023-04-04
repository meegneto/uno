#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactPicker 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Contacts.ContactSelectionMode SelectionMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactSelectionMode ContactPicker.SelectionMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContactSelectionMode%20ContactPicker.SelectionMode");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactPicker", "ContactSelectionMode ContactPicker.SelectionMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string CommitButtonText
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ContactPicker.CommitButtonText is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ContactPicker.CommitButtonText");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactPicker", "string ContactPicker.CommitButtonText");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<string> DesiredFields
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<string> ContactPicker.DesiredFields is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3Cstring%3E%20ContactPicker.DesiredFields");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.ApplicationModel.Contacts.ContactFieldType> DesiredFieldsWithContactFieldType
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ContactFieldType> ContactPicker.DesiredFieldsWithContactFieldType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CContactFieldType%3E%20ContactPicker.DesiredFieldsWithContactFieldType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User ContactPicker.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=User%20ContactPicker.User");
			}
		}
		#endif
		// Skipping already declared method Windows.ApplicationModel.Contacts.ContactPicker.ContactPicker()
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactPicker.ContactPicker()
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactPicker.CommitButtonText.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactPicker.CommitButtonText.set
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactPicker.SelectionMode.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactPicker.SelectionMode.set
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactPicker.DesiredFields.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactInformation> PickSingleContactAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactInformation> ContactPicker.PickSingleContactAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CContactInformation%3E%20ContactPicker.PickSingleContactAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.ContactInformation>> PickMultipleContactsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ContactInformation>> ContactPicker.PickMultipleContactsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CContactInformation%3E%3E%20ContactPicker.PickMultipleContactsAsync%28%29");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactPicker.DesiredFieldsWithContactFieldType.get
		// Skipping already declared method Windows.ApplicationModel.Contacts.ContactPicker.PickContactAsync()
		// Skipping already declared method Windows.ApplicationModel.Contacts.ContactPicker.PickContactsAsync()
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactPicker.User.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Contacts.ContactPicker CreateForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member ContactPicker ContactPicker.CreateForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContactPicker%20ContactPicker.CreateForUser%28User%20user%29");
		}
		#endif
		// Skipping already declared method Windows.ApplicationModel.Contacts.ContactPicker.IsSupportedAsync()
	}
}