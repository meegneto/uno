#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Vector3Transition 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan Duration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan Vector3Transition.Duration is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20Vector3Transition.Duration");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Vector3Transition", "TimeSpan Vector3Transition.Duration");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Vector3TransitionComponents Components
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3TransitionComponents Vector3Transition.Components is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector3TransitionComponents%20Vector3Transition.Components");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Vector3Transition", "Vector3TransitionComponents Vector3Transition.Components");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public Vector3Transition() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Vector3Transition", "Vector3Transition.Vector3Transition()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Vector3Transition.Vector3Transition()
		// Forced skipping of method Microsoft.UI.Xaml.Vector3Transition.Duration.get
		// Forced skipping of method Microsoft.UI.Xaml.Vector3Transition.Duration.set
		// Forced skipping of method Microsoft.UI.Xaml.Vector3Transition.Components.get
		// Forced skipping of method Microsoft.UI.Xaml.Vector3Transition.Components.set
	}
}