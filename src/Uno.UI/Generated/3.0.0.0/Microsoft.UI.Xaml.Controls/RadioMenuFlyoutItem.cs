#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class RadioMenuFlyoutItem 
	{
		// Skipping already declared property IsChecked
		// Skipping already declared property GroupName
		// Skipping already declared property GroupNameProperty
		// Skipping already declared property IsCheckedProperty
		// Skipping already declared property AreCheckStatesEnabledProperty
		// Skipping already declared method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.RadioMenuFlyoutItem()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.RadioMenuFlyoutItem()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.IsChecked.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.IsChecked.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.GroupName.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.GroupName.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.AreCheckStatesEnabledProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetAreCheckStatesEnabled( global::Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem @object,  bool value)
		{
			@object.SetValue(AreCheckStatesEnabledProperty, value);
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool GetAreCheckStatesEnabled( global::Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem @object)
		{
			return (bool)@object.GetValue(AreCheckStatesEnabledProperty);
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.IsCheckedProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.GroupNameProperty.get
	}
}