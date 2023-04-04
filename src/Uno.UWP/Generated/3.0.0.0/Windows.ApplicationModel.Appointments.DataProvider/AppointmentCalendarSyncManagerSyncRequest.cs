#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Appointments.DataProvider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppointmentCalendarSyncManagerSyncRequest 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string AppointmentCalendarLocalId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AppointmentCalendarSyncManagerSyncRequest.AppointmentCalendarLocalId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20AppointmentCalendarSyncManagerSyncRequest.AppointmentCalendarLocalId");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarSyncManagerSyncRequest.AppointmentCalendarLocalId.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportCompletedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AppointmentCalendarSyncManagerSyncRequest.ReportCompletedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20AppointmentCalendarSyncManagerSyncRequest.ReportCompletedAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportFailedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AppointmentCalendarSyncManagerSyncRequest.ReportFailedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20AppointmentCalendarSyncManagerSyncRequest.ReportFailedAsync%28%29");
		}
		#endif
	}
}