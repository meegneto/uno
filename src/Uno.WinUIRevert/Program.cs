﻿#nullable enable
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace UnoWinUIRevert
{
	class Program
	{
		static void Main(string[] args)
		{
			var basePath = args[0];

			DeleteFolder(Path.Combine(basePath, "src", "Uno.UI", "Generated"));
			DeleteFolder(Path.Combine(basePath, "src", "Uno.UI.Composition", "Generated"));
			DeleteFolder(Path.Combine(basePath, "src", "Uno.UWP", "Generated"));
			DeleteFolder(Path.Combine(basePath, "src", "Uno.UI", "tsBindings")); // Generated

			var colorsFilepath = Path.Combine(basePath, @"src", "Uno.UI", "UI", "Colors.cs");
			if (File.Exists(colorsFilepath))
			{
				File.Delete(colorsFilepath);
			}

			var colorHelperFilePath = Path.Combine(basePath, @"src", "Uno.UI", "UI", "ColorHelper.cs");
			if (File.Exists(colorHelperFilePath))
			{
				File.Delete(colorHelperFilePath);
			}

			var fontWeightsFilePath = Path.Combine(basePath, @"src", "Uno.UI", "UI", "Text", "FontWeights.cs");
			if (File.Exists(fontWeightsFilePath))
			{
				File.Delete(fontWeightsFilePath);
			}

			var inputPath = Path.Combine(basePath, "src", "Uno.UI", "UI", "Input");
			if (Directory.Exists(inputPath))
			{
				Directory.Delete(inputPath, true);
			}

			var dispatcherQueuePath = Path.Combine(basePath, "src", "Uno.UI.Dispatching", "Dispatching");
			if (Directory.Exists(dispatcherQueuePath))
			{
				Directory.Delete(dispatcherQueuePath, true);
			}

			// Replace microsoft namespaces in a reversible way
			ReplaceInFolders(basePath,
				new[] {
				("Microsoft/* UWP don't rename */.UI.Xaml", "Microsoft/* UWP don't rename */.UI.Xaml") }
				, searchPattern: "*.cs"
			);

			// Generic replacements
			var genericReplacements = new[] {
				("Microsoft.UI.Xaml", "Windows.UI.Xaml"),
				("Microsoft.UI.Composition", "Windows.UI.Composition"),
				("Microsoft.UI.Colors", "Windows.UI.Colors"),
				("Microsoft.UI.Text.FontWeights", "Windows.UI.Text.FontWeights"),
				("Microsoft.UI.ColorHelper", "Windows.UI.ColorHelper"),
				("Microsoft.UI.Xaml", "Windows.UI.Xaml"),
				("__LinkerHints.Is_Microsoft_UI_Xaml", "__LinkerHints.Is_Windows_UI_Xaml"),
				("__LinkerHints.Is_Windows_UI_Xaml_Controls_LayoutPanel", "__LinkerHints.Is_Microsoft_UI_Xaml_Controls_LayoutPanel"),
				("Uno.UI.Controls.Legacy\", \"ProgressRing", "Windows.UI.Xaml.Controls\", \"ProgressRing"),
				("<UNO_UWP_BUILD>false</UNO_UWP_BUILD>", "<UNO_UWP_BUILD>true</UNO_UWP_BUILD>"),
			};

			ReplaceInFolders(basePath, genericReplacements);

			// Restore ProgressRing
			var progressRingReplacements = new[] {
				("Uno.UI.Controls.Legacy", "Windows.UI.Xaml.Controls"),
			};

			ReplaceInFolders(Path.Combine(basePath, @"src", "Uno.UI", "UI", "Xaml", "Controls", "ProgressRing"), progressRingReplacements);
			ReplaceInFile(Path.Combine(basePath, @"src", "Uno.UI", "UI", "Xaml", "Controls", "ProgressRing", "ProgressRing.xaml"), "\"legacy:ProgressRing\"", "\"ProgressRing\"");
			ReplaceInFile(Path.Combine(basePath, @"src", "Uno.UI", "UI", "Xaml", "Style", "Generic", "Generic.Native.xaml"), "legacy:ProgressRing", "ProgressRing");
			ReplaceInFile(Path.Combine(basePath, @"src", "Uno.UI", "Microsoft", "UI", "Xaml", "Controls", "ProgressRing", "ProgressRing.xaml"), "using:Uno.UI.Controls.Legacy", "using:Microsoft.UI.Xaml.Controls");

			ReplaceInFile(Path.Combine(basePath, @"src", "SourceGenerators", "Uno.UI.SourceGenerators", "XamlGenerator", "XamlConstants.cs"), "Microsoft.UI", "Windows.UI");
			ReplaceInFile(Path.Combine(basePath, @"src", "Uno.UI", "UI", "Xaml", "Markup", "Reader", "XamlConstants.cs"), "Microsoft.UI", "Windows.UI");

			UncommentWinUISpecificBlock(Path.Combine(basePath, "build", "nuget", "Uno.WinUI.nuspec"));

			// Replace microsoft namespaces in a reversible way
			// This particular section assumes that UWP controls are not prefixed with `using:Windows.UI.Xaml`
			var styleFolders = new[] {
				Path.Combine(basePath, "src", "Uno.UI", "Microsoft", "UI", "Xaml", "Controls"),
				Path.Combine(basePath, "src", "Uno.UI", "UI", "Xaml", "Style"),
				Path.Combine(basePath, "src", "Uno.UI.FluentTheme.v2", "Resources"),
				Path.Combine(basePath, "src", "Uno.UI.FluentTheme.v1", "Resources"),
			};

			foreach (var styleFolder in styleFolders)
			{
				ReplaceInFolders(
					styleFolder,
					new[] {
					("using:Windows.UI.Xaml", "using:Microsoft.UI.Xaml") }
					, searchPattern: "*.xaml"
				);
			}
		}

		static string[] _exclusions = new string[] {
			"Uno.UWPSyncGenerator.Reference.csproj",
			"SamplesApp.UWP.csproj",
			"SamplesApp.UWP.Design.csproj",
			@"Uno.UWPSyncGenerator",
			@"src\Uno.UWP\",
			@"src\Uno.UI\UI\Xaml\Controls\NavigationView\",
			@"src\Uno.UI.RuntimeTests\Tests\Windows_UI_Xaml_Controls\Given_NavigationView.cs",
			@"\obj\",
			@"\bin\",
			@"\.git",
			@"\.vs",
			@"\docs\",
		}
		.Select(AlignPath)
		.ToArray();

		private static string AlignPath(string p) => p.Replace('\\', Path.DirectorySeparatorChar);

		private static void ReplaceInFolders(string basePath, (string from, string to)[] replacements, string searchPattern = "*.*")
		{
			Directory.EnumerateFiles(basePath, searchPattern, SearchOption.AllDirectories)
				.AsParallel()
				.ForAll(file =>
				{
					if (_exclusions.Any(e => file.Contains(e, StringComparison.OrdinalIgnoreCase)))
					{
						return;
					}

					var updated = false;
					var content = File.ReadAllText(file);

					for (int i = 0; i < replacements.Length; i++)
					{
						if (content.Contains(replacements[i].from))
						{
							content = content.Replace(replacements[i].from, replacements[i].to);
							updated = true;
						}
					}

					if (updated)
					{
						Console.WriteLine($"Updating [{file}]");

						int retry = 3;
						while (retry-- > 0)
						{
							try
							{
								File.WriteAllText(file, content, Encoding.UTF8);
							}
							catch
							{
								System.Threading.Thread.Sleep(500);
							}
						}
					}
				});
		}

		private static void DeleteFolder(string path)
		{
			if (Directory.Exists(path))
			{
				Console.WriteLine($"Deleting {path}");
				Directory.Delete(path, true);
			}
		}

		private static void ReplaceInFile(string filePath, string from, string to)
		{
			Console.WriteLine($"Updating [{filePath}]");

			var txt = File.ReadAllText(filePath);
			txt = txt.Replace(from, to);
			File.WriteAllText(filePath, txt, Encoding.UTF8);
		}

		private static void UncommentWinUISpecificBlock(string nuspecPath)
		{
			ReplaceInFile(nuspecPath, @"<!-- BEGIN UWP-excluded -->", "<!-- WinUI Specific ");
			ReplaceInFile(nuspecPath, @"<!-- END UWP-excluded -->", "-->");
		}
	}
}
