#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AutomationAnnotation : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Automation.AnnotationType Type
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Automation.AnnotationType)this.GetValue(TypeProperty);
			}
			set
			{
				this.SetValue(TypeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.UIElement Element
		{
			get
			{
				return (global::Microsoft.UI.Xaml.UIElement)this.GetValue(ElementProperty);
			}
			set
			{
				this.SetValue(ElementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ElementProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Element), typeof(global::Microsoft.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Automation.AutomationAnnotation), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty TypeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Type), typeof(global::Microsoft.UI.Xaml.Automation.AnnotationType), 
			typeof(global::Microsoft.UI.Xaml.Automation.AutomationAnnotation), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Automation.AnnotationType)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public AutomationAnnotation( global::Microsoft.UI.Xaml.Automation.AnnotationType type) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.AutomationAnnotation", "AutomationAnnotation.AutomationAnnotation(AnnotationType type)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.AutomationAnnotation.AutomationAnnotation(Microsoft.UI.Xaml.Automation.AnnotationType)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public AutomationAnnotation( global::Microsoft.UI.Xaml.Automation.AnnotationType type,  global::Microsoft.UI.Xaml.UIElement element) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.AutomationAnnotation", "AutomationAnnotation.AutomationAnnotation(AnnotationType type, UIElement element)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.AutomationAnnotation.AutomationAnnotation(Microsoft.UI.Xaml.Automation.AnnotationType, Microsoft.UI.Xaml.UIElement)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public AutomationAnnotation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.AutomationAnnotation", "AutomationAnnotation.AutomationAnnotation()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.AutomationAnnotation.AutomationAnnotation()
		// Forced skipping of method Microsoft.UI.Xaml.Automation.AutomationAnnotation.Type.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.AutomationAnnotation.Type.set
		// Forced skipping of method Microsoft.UI.Xaml.Automation.AutomationAnnotation.Element.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.AutomationAnnotation.Element.set
		// Forced skipping of method Microsoft.UI.Xaml.Automation.AutomationAnnotation.TypeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.AutomationAnnotation.ElementProperty.get
	}
}