#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ComboBoxHelper 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeepInteriorCornersSquareProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"KeepInteriorCornersSquare", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ComboBoxHelper), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ComboBoxHelper.KeepInteriorCornersSquareProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetKeepInteriorCornersSquare( global::Microsoft.UI.Xaml.Controls.ComboBox comboBox,  bool value)
		{
			comboBox.SetValue(KeepInteriorCornersSquareProperty, value);
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool GetKeepInteriorCornersSquare( global::Microsoft.UI.Xaml.Controls.ComboBox comboBox)
		{
			return (bool)comboBox.GetValue(KeepInteriorCornersSquareProperty);
		}
		#endif
	}
}