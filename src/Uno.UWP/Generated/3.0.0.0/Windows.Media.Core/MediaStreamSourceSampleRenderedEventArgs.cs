#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaStreamSourceSampleRenderedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan SampleLag
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan MediaStreamSourceSampleRenderedEventArgs.SampleLag is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20MediaStreamSourceSampleRenderedEventArgs.SampleLag");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.MediaStreamSourceSampleRenderedEventArgs.SampleLag.get
	}
}