#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class AudioEffectsManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Media.Effects.AudioRenderEffectsManager CreateAudioRenderEffectsManager( string deviceId,  global::Windows.Media.Render.AudioRenderCategory category)
		{
			throw new global::System.NotImplementedException("The member AudioRenderEffectsManager AudioEffectsManager.CreateAudioRenderEffectsManager(string deviceId, AudioRenderCategory category) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AudioRenderEffectsManager%20AudioEffectsManager.CreateAudioRenderEffectsManager%28string%20deviceId%2C%20AudioRenderCategory%20category%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Media.Effects.AudioRenderEffectsManager CreateAudioRenderEffectsManager( string deviceId,  global::Windows.Media.Render.AudioRenderCategory category,  global::Windows.Media.AudioProcessing mode)
		{
			throw new global::System.NotImplementedException("The member AudioRenderEffectsManager AudioEffectsManager.CreateAudioRenderEffectsManager(string deviceId, AudioRenderCategory category, AudioProcessing mode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AudioRenderEffectsManager%20AudioEffectsManager.CreateAudioRenderEffectsManager%28string%20deviceId%2C%20AudioRenderCategory%20category%2C%20AudioProcessing%20mode%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Media.Effects.AudioCaptureEffectsManager CreateAudioCaptureEffectsManager( string deviceId,  global::Windows.Media.Capture.MediaCategory category)
		{
			throw new global::System.NotImplementedException("The member AudioCaptureEffectsManager AudioEffectsManager.CreateAudioCaptureEffectsManager(string deviceId, MediaCategory category) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AudioCaptureEffectsManager%20AudioEffectsManager.CreateAudioCaptureEffectsManager%28string%20deviceId%2C%20MediaCategory%20category%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Media.Effects.AudioCaptureEffectsManager CreateAudioCaptureEffectsManager( string deviceId,  global::Windows.Media.Capture.MediaCategory category,  global::Windows.Media.AudioProcessing mode)
		{
			throw new global::System.NotImplementedException("The member AudioCaptureEffectsManager AudioEffectsManager.CreateAudioCaptureEffectsManager(string deviceId, MediaCategory category, AudioProcessing mode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AudioCaptureEffectsManager%20AudioEffectsManager.CreateAudioCaptureEffectsManager%28string%20deviceId%2C%20MediaCategory%20category%2C%20AudioProcessing%20mode%29");
		}
		#endif
	}
}