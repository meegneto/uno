#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Effects
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositeVideoFrameContext 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.VideoFrame BackgroundFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member VideoFrame CompositeVideoFrameContext.BackgroundFrame is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VideoFrame%20CompositeVideoFrameContext.BackgroundFrame");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.VideoFrame OutputFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member VideoFrame CompositeVideoFrameContext.OutputFrame is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VideoFrame%20CompositeVideoFrameContext.OutputFrame");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface> SurfacesToOverlay
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<IDirect3DSurface> CompositeVideoFrameContext.SurfacesToOverlay is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CIDirect3DSurface%3E%20CompositeVideoFrameContext.SurfacesToOverlay");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Effects.CompositeVideoFrameContext.SurfacesToOverlay.get
		// Forced skipping of method Windows.Media.Effects.CompositeVideoFrameContext.BackgroundFrame.get
		// Forced skipping of method Windows.Media.Effects.CompositeVideoFrameContext.OutputFrame.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Editing.MediaOverlay GetOverlayForSurface( global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface surfaceToOverlay)
		{
			throw new global::System.NotImplementedException("The member MediaOverlay CompositeVideoFrameContext.GetOverlayForSurface(IDirect3DSurface surfaceToOverlay) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaOverlay%20CompositeVideoFrameContext.GetOverlayForSurface%28IDirect3DSurface%20surfaceToOverlay%29");
		}
		#endif
	}
}