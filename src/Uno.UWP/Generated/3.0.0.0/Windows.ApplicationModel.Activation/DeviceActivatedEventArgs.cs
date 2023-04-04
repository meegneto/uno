#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DeviceActivatedEventArgs : global::Windows.ApplicationModel.Activation.IDeviceActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs,global::Windows.ApplicationModel.Activation.IViewSwitcherProvider,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind DeviceActivatedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ActivationKind%20DeviceActivatedEventArgs.Kind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState DeviceActivatedEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ApplicationExecutionState%20DeviceActivatedEventArgs.PreviousExecutionState");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen DeviceActivatedEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SplashScreen%20DeviceActivatedEventArgs.SplashScreen");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User DeviceActivatedEventArgs.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=User%20DeviceActivatedEventArgs.User");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int CurrentlyShownApplicationViewId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int DeviceActivatedEventArgs.CurrentlyShownApplicationViewId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20DeviceActivatedEventArgs.CurrentlyShownApplicationViewId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceInformationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string DeviceActivatedEventArgs.DeviceInformationId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20DeviceActivatedEventArgs.DeviceInformationId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Verb
		{
			get
			{
				throw new global::System.NotImplementedException("The member string DeviceActivatedEventArgs.Verb is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20DeviceActivatedEventArgs.Verb");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.ViewManagement.ActivationViewSwitcher ViewSwitcher
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationViewSwitcher DeviceActivatedEventArgs.ViewSwitcher is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ActivationViewSwitcher%20DeviceActivatedEventArgs.ViewSwitcher");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.DeviceActivatedEventArgs.DeviceInformationId.get
		// Forced skipping of method Windows.ApplicationModel.Activation.DeviceActivatedEventArgs.Verb.get
		// Forced skipping of method Windows.ApplicationModel.Activation.DeviceActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.ApplicationModel.Activation.DeviceActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.ApplicationModel.Activation.DeviceActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.ApplicationModel.Activation.DeviceActivatedEventArgs.CurrentlyShownApplicationViewId.get
		// Forced skipping of method Windows.ApplicationModel.Activation.DeviceActivatedEventArgs.ViewSwitcher.get
		// Forced skipping of method Windows.ApplicationModel.Activation.DeviceActivatedEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IDeviceActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IViewSwitcherProvider
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}