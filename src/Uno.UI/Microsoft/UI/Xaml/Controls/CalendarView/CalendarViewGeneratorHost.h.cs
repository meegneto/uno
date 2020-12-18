﻿using System;
using System.Collections.Generic;
using Windows.Globalization;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using DateTime = System.DateTimeOffset;

namespace Windows.UI.Xaml.Controls
{
	partial class CalendarViewGeneratorHost : IDirectManipulationStateChangeHandler
	{
		internal int[] GetLastVisibleIndicesPairRef() { return m_lastVisibleIndicesPair; }

		internal DateTime GetMinDateOfCurrentScope() { return m_minDateOfCurrentScope; }
		internal DateTime GetMaxDateOfCurrentScope() { return m_maxDateOfCurrentScope; }
		internal string GetHeaderTextOfCurrentScope() { return m_pHeaderText; }
	}
}
