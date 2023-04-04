#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if false || false || false || false || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class Pedometer 
	{
		#if false || false || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Pedometer.ReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20Pedometer.ReportInterval");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Pedometer", "uint Pedometer.ReportInterval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Pedometer.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20Pedometer.DeviceId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MinimumReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Pedometer.MinimumReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20Pedometer.MinimumReportInterval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double PowerInMilliwatts
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Pedometer.PowerInMilliwatts is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=double%20Pedometer.PowerInMilliwatts");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.Pedometer.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.Pedometer.PowerInMilliwatts.get
		// Forced skipping of method Windows.Devices.Sensors.Pedometer.MinimumReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Pedometer.ReportInterval.set
		// Forced skipping of method Windows.Devices.Sensors.Pedometer.ReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Pedometer.ReadingChanged.add
		// Forced skipping of method Windows.Devices.Sensors.Pedometer.ReadingChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyDictionary<global::Windows.Devices.Sensors.PedometerStepKind, global::Windows.Devices.Sensors.PedometerReading> GetCurrentReadings()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyDictionary<PedometerStepKind, PedometerReading> Pedometer.GetCurrentReadings() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyDictionary%3CPedometerStepKind%2C%20PedometerReading%3E%20Pedometer.GetCurrentReadings%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Sensors.PedometerReading> GetReadingsFromTriggerDetails( global::Windows.Devices.Sensors.SensorDataThresholdTriggerDetails triggerDetails)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<PedometerReading> Pedometer.GetReadingsFromTriggerDetails(SensorDataThresholdTriggerDetails triggerDetails) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CPedometerReading%3E%20Pedometer.GetReadingsFromTriggerDetails%28SensorDataThresholdTriggerDetails%20triggerDetails%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.Pedometer> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Pedometer> Pedometer.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CPedometer%3E%20Pedometer.FromIdAsync%28string%20deviceId%29");
		}
		#endif
		#if false || false || false || false || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.Pedometer> GetDefaultAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Pedometer> Pedometer.GetDefaultAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CPedometer%3E%20Pedometer.GetDefaultAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDeviceSelector()
		{
			throw new global::System.NotImplementedException("The member string Pedometer.GetDeviceSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20Pedometer.GetDeviceSelector%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Sensors.PedometerReading>> GetSystemHistoryAsync( global::System.DateTimeOffset fromTime)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<PedometerReading>> Pedometer.GetSystemHistoryAsync(DateTimeOffset fromTime) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CPedometerReading%3E%3E%20Pedometer.GetSystemHistoryAsync%28DateTimeOffset%20fromTime%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Sensors.PedometerReading>> GetSystemHistoryAsync( global::System.DateTimeOffset fromTime,  global::System.TimeSpan duration)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<PedometerReading>> Pedometer.GetSystemHistoryAsync(DateTimeOffset fromTime, TimeSpan duration) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CPedometerReading%3E%3E%20Pedometer.GetSystemHistoryAsync%28DateTimeOffset%20fromTime%2C%20TimeSpan%20duration%29");
		}
		#endif
		#if false || false || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.Pedometer, global::Windows.Devices.Sensors.PedometerReadingChangedEventArgs> ReadingChanged
		{
			[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Pedometer", "event TypedEventHandler<Pedometer, PedometerReadingChangedEventArgs> Pedometer.ReadingChanged");
			}
			[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Pedometer", "event TypedEventHandler<Pedometer, PedometerReadingChangedEventArgs> Pedometer.ReadingChanged");
			}
		}
		#endif
	}
}