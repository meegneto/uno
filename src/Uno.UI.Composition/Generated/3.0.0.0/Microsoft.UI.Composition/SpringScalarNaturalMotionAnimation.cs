#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpringScalarNaturalMotionAnimation : global::Microsoft.UI.Composition.ScalarNaturalMotionAnimation
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan Period
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan SpringScalarNaturalMotionAnimation.Period is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20SpringScalarNaturalMotionAnimation.Period");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation", "TimeSpan SpringScalarNaturalMotionAnimation.Period");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float DampingRatio
		{
			get
			{
				throw new global::System.NotImplementedException("The member float SpringScalarNaturalMotionAnimation.DampingRatio is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20SpringScalarNaturalMotionAnimation.DampingRatio");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation", "float SpringScalarNaturalMotionAnimation.DampingRatio");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation.DampingRatio.get
		// Forced skipping of method Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation.Period.set
		// Forced skipping of method Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation.DampingRatio.set
		// Forced skipping of method Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation.Period.get
	}
}