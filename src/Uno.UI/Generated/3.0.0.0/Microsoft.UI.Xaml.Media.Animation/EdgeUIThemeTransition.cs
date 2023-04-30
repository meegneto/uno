#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EdgeUIThemeTransition : global::Microsoft.UI.Xaml.Media.Animation.Transition
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.EdgeTransitionLocation Edge
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Primitives.EdgeTransitionLocation)this.GetValue(EdgeProperty);
			}
			set
			{
				this.SetValue(EdgeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty EdgeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Edge), typeof(global::Microsoft.UI.Xaml.Controls.Primitives.EdgeTransitionLocation), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.EdgeUIThemeTransition), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.EdgeTransitionLocation)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public EdgeUIThemeTransition() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.EdgeUIThemeTransition", "EdgeUIThemeTransition.EdgeUIThemeTransition()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EdgeUIThemeTransition.EdgeUIThemeTransition()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EdgeUIThemeTransition.Edge.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EdgeUIThemeTransition.Edge.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EdgeUIThemeTransition.EdgeProperty.get
	}
}