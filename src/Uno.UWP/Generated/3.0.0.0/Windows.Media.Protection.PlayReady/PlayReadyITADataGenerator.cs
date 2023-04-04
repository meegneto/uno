#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection.PlayReady
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PlayReadyITADataGenerator 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PlayReadyITADataGenerator() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Protection.PlayReady.PlayReadyITADataGenerator", "PlayReadyITADataGenerator.PlayReadyITADataGenerator()");
		}
		#endif
		// Forced skipping of method Windows.Media.Protection.PlayReady.PlayReadyITADataGenerator.PlayReadyITADataGenerator()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte[] GenerateData( global::System.Guid guidCPSystemId,  uint countOfStreams,  global::Windows.Foundation.Collections.IPropertySet configuration,  global::Windows.Media.Protection.PlayReady.PlayReadyITADataFormat format)
		{
			throw new global::System.NotImplementedException("The member byte[] PlayReadyITADataGenerator.GenerateData(Guid guidCPSystemId, uint countOfStreams, IPropertySet configuration, PlayReadyITADataFormat format) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=byte%5B%5D%20PlayReadyITADataGenerator.GenerateData%28Guid%20guidCPSystemId%2C%20uint%20countOfStreams%2C%20IPropertySet%20configuration%2C%20PlayReadyITADataFormat%20format%29");
		}
		#endif
	}
}