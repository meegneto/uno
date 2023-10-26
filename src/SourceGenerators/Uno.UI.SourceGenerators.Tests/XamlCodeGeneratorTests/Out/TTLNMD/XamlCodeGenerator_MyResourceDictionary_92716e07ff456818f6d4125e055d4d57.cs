﻿// <autogenerated />
#pragma warning disable CS0114
#pragma warning disable CS0108
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers;
using Uno.UI.Helpers.Xaml;
using MyProject;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#else
using _View = Microsoft.UI.Xaml.UIElement;
#endif

namespace MyProject
{
	public sealed partial class GlobalStaticResources
	{
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_prefix_MyResourceDictionary_92716e07ff456818f6d4125e055d4d57 = "ms-appx:///TestProject/";
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_MyResourceDictionary_92716e07ff456818f6d4125e055d4d57 = "ms-appx:///TestProject/";
		// This non-static inner class is a means of reducing size of AOT compilations by avoiding many accesses to static members from a static callsite, which adds costly class initializer checks each time.
		internal sealed class ResourceDictionarySingleton__MyResourceDictionary_92716e07ff456818f6d4125e055d4d57 : global::Uno.UI.IXamlResourceDictionaryProvider
		{
			private static global::Microsoft.UI.Xaml.NameScope __nameScope = new global::Microsoft.UI.Xaml.NameScope();
			private static ResourceDictionarySingleton__MyResourceDictionary_92716e07ff456818f6d4125e055d4d57 __that;
			internal static ResourceDictionarySingleton__MyResourceDictionary_92716e07ff456818f6d4125e055d4d57 Instance
			{
				get
				{
					if (__that == null)
					{
						__that = new ResourceDictionarySingleton__MyResourceDictionary_92716e07ff456818f6d4125e055d4d57();
					}

					return __that;
				}
			}

			internal global::Uno.UI.Xaml.XamlParseContext __ParseContext_ {get; }

			private ResourceDictionarySingleton__MyResourceDictionary_92716e07ff456818f6d4125e055d4d57()
			{
				__ParseContext_ = global::MyProject.GlobalStaticResources.__ParseContext_;
			}

			private global::Microsoft.UI.Xaml.ResourceDictionary _MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary;

			internal global::Microsoft.UI.Xaml.ResourceDictionary MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary
			{
				get
				{
					if (_MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary == null)
					{
						_MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary = 
						new global::Microsoft.UI.Xaml.ResourceDictionary
						{
							IsParsing = true,
							MergedDictionaries = {
							// Source not resolved statically, falling back on external resource retrieval.
							global::Uno.UI.ResourceResolver.RetrieveDictionaryForSource("ms-appx:///Path/To/File1.xaml", "C:/Project/0/MyResourceDictionary.xaml")
							.AddMergedDictionaries(
							// MergedDictionaries
							// Source not resolved statically, falling back on external resource retrieval.
							global::Uno.UI.ResourceResolver.RetrieveDictionaryForSource("ms-appx:///Path/To/File2.xaml", "C:/Project/0/MyResourceDictionary.xaml")
							.AddMergedDictionaries(
							// MergedDictionaries
							// Source not resolved statically, falling back on external resource retrieval.
							global::Uno.UI.ResourceResolver.RetrieveDictionaryForSource("ms-appx:///Path/To/File3.xaml", "C:/Project/0/MyResourceDictionary.xaml")
							)
							)
							,
							},
						}
						;
						_MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary.Source = new global::System.Uri("ms-resource:///Files/C:/Project/0/MyResourceDictionary.xaml");
						_MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary.CreationComplete();
					}
					return _MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary;
				}
			}

			global::Microsoft.UI.Xaml.ResourceDictionary global::Uno.UI.IXamlResourceDictionaryProvider.GetResourceDictionary() => MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary;
		}

		internal static global::Microsoft.UI.Xaml.ResourceDictionary MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary => ResourceDictionarySingleton__MyResourceDictionary_92716e07ff456818f6d4125e055d4d57.Instance.MyResourceDictionary_92716e07ff456818f6d4125e055d4d57_ResourceDictionary;
	}
}
namespace MyProject.__Resources
{
}
namespace MyProject
{
	static class MyResourceDictionary_92716e07ff456818f6d4125e055d4d57XamlApplyExtensions
	{
	}
}
