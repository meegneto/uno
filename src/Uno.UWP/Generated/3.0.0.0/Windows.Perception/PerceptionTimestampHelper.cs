#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class PerceptionTimestampHelper 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Perception.PerceptionTimestamp FromSystemRelativeTargetTime( global::System.TimeSpan targetTime)
		{
			throw new global::System.NotImplementedException("The member PerceptionTimestamp PerceptionTimestampHelper.FromSystemRelativeTargetTime(TimeSpan targetTime) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PerceptionTimestamp%20PerceptionTimestampHelper.FromSystemRelativeTargetTime%28TimeSpan%20targetTime%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Perception.PerceptionTimestamp FromHistoricalTargetTime( global::System.DateTimeOffset targetTime)
		{
			throw new global::System.NotImplementedException("The member PerceptionTimestamp PerceptionTimestampHelper.FromHistoricalTargetTime(DateTimeOffset targetTime) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PerceptionTimestamp%20PerceptionTimestampHelper.FromHistoricalTargetTime%28DateTimeOffset%20targetTime%29");
		}
		#endif
	}
}