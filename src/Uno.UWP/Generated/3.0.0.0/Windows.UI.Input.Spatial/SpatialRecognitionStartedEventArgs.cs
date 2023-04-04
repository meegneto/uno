#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Spatial
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpatialRecognitionStartedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Spatial.SpatialInteractionSourceKind InteractionSourceKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpatialInteractionSourceKind SpatialRecognitionStartedEventArgs.InteractionSourceKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SpatialInteractionSourceKind%20SpatialRecognitionStartedEventArgs.InteractionSourceKind");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Spatial.SpatialRecognitionStartedEventArgs.InteractionSourceKind.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Spatial.SpatialPointerPose TryGetPointerPose( global::Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
		{
			throw new global::System.NotImplementedException("The member SpatialPointerPose SpatialRecognitionStartedEventArgs.TryGetPointerPose(SpatialCoordinateSystem coordinateSystem) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SpatialPointerPose%20SpatialRecognitionStartedEventArgs.TryGetPointerPose%28SpatialCoordinateSystem%20coordinateSystem%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsGesturePossible( global::Windows.UI.Input.Spatial.SpatialGestureSettings gesture)
		{
			throw new global::System.NotImplementedException("The member bool SpatialRecognitionStartedEventArgs.IsGesturePossible(SpatialGestureSettings gesture) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20SpatialRecognitionStartedEventArgs.IsGesturePossible%28SpatialGestureSettings%20gesture%29");
		}
		#endif
	}
}