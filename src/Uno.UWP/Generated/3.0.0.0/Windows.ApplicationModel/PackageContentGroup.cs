#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PackageContentGroup 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsRequired
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PackageContentGroup.IsRequired is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20PackageContentGroup.IsRequired");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PackageContentGroup.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20PackageContentGroup.Name");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Package Package
		{
			get
			{
				throw new global::System.NotImplementedException("The member Package PackageContentGroup.Package is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Package%20PackageContentGroup.Package");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.PackageContentGroupState State
		{
			get
			{
				throw new global::System.NotImplementedException("The member PackageContentGroupState PackageContentGroup.State is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PackageContentGroupState%20PackageContentGroup.State");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string RequiredGroupName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PackageContentGroup.RequiredGroupName is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20PackageContentGroup.RequiredGroupName");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.PackageContentGroup.Package.get
		// Forced skipping of method Windows.ApplicationModel.PackageContentGroup.Name.get
		// Forced skipping of method Windows.ApplicationModel.PackageContentGroup.State.get
		// Forced skipping of method Windows.ApplicationModel.PackageContentGroup.IsRequired.get
		// Forced skipping of method Windows.ApplicationModel.PackageContentGroup.RequiredGroupName.get
	}
}