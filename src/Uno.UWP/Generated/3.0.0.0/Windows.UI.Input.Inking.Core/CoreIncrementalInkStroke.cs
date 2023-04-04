#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreIncrementalInkStroke 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect BoundingRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect CoreIncrementalInkStroke.BoundingRect is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Rect%20CoreIncrementalInkStroke.BoundingRect");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Inking.InkDrawingAttributes DrawingAttributes
		{
			get
			{
				throw new global::System.NotImplementedException("The member InkDrawingAttributes CoreIncrementalInkStroke.DrawingAttributes is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=InkDrawingAttributes%20CoreIncrementalInkStroke.DrawingAttributes");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Matrix3x2 PointTransform
		{
			get
			{
				throw new global::System.NotImplementedException("The member Matrix3x2 CoreIncrementalInkStroke.PointTransform is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Matrix3x2%20CoreIncrementalInkStroke.PointTransform");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public CoreIncrementalInkStroke( global::Windows.UI.Input.Inking.InkDrawingAttributes drawingAttributes,  global::System.Numerics.Matrix3x2 pointTransform) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.Core.CoreIncrementalInkStroke", "CoreIncrementalInkStroke.CoreIncrementalInkStroke(InkDrawingAttributes drawingAttributes, Matrix3x2 pointTransform)");
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Inking.Core.CoreIncrementalInkStroke.CoreIncrementalInkStroke(Windows.UI.Input.Inking.InkDrawingAttributes, System.Numerics.Matrix3x2)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect AppendInkPoints( global::System.Collections.Generic.IEnumerable<global::Windows.UI.Input.Inking.InkPoint> inkPoints)
		{
			throw new global::System.NotImplementedException("The member Rect CoreIncrementalInkStroke.AppendInkPoints(IEnumerable<InkPoint> inkPoints) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Rect%20CoreIncrementalInkStroke.AppendInkPoints%28IEnumerable%3CInkPoint%3E%20inkPoints%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Inking.InkStroke CreateInkStroke()
		{
			throw new global::System.NotImplementedException("The member InkStroke CoreIncrementalInkStroke.CreateInkStroke() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=InkStroke%20CoreIncrementalInkStroke.CreateInkStroke%28%29");
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Inking.Core.CoreIncrementalInkStroke.DrawingAttributes.get
		// Forced skipping of method Windows.UI.Input.Inking.Core.CoreIncrementalInkStroke.PointTransform.get
		// Forced skipping of method Windows.UI.Input.Inking.Core.CoreIncrementalInkStroke.BoundingRect.get
	}
}