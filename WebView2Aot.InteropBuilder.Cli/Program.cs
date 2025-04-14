using System.IO;
using Win32InteropBuilder.Utilities;

namespace WebView2Aot.InteropBuilder.Cli;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("WebView2Aot Builder - Copyright (C) 2024-" + DateTime.Now.Year + " Simon Mourier. All rights reserved.");
        Console.WriteLine();
        var configurationPath = CommandLine.Current.GetNullifiedArgument(0, "WebView2Aot.json");
        if (CommandLine.Current.HelpRequested || configurationPath == null)
        {
            Help();
            return;
        }

        var winMdPath = Path.Combine(Win32Metadata.WinMdPath, "Microsoft.Web.WebView2.Win32.winmd");
        Win32InteropBuilder.Builder.Run(configurationPath, winMdPath);
    }

    static void Help()
    {
        Console.WriteLine(Assembly.GetEntryAssembly()!.GetName().Name!.ToUpperInvariant() + " [WebView2Aot.json] <outputDirectoryPath>");
        Console.WriteLine();
        Console.WriteLine("Description:");
        Console.WriteLine("    This tool is used to generate WebView2 AOT-friendly interop .cs files from Microsoft.Web.WebView2.Win32.winmd.");
        Console.WriteLine();
        Console.WriteLine("Examples:");
        Console.WriteLine();
        Console.WriteLine("    " + Assembly.GetEntryAssembly()!.GetName().Name!.ToUpperInvariant() + @" c:\myPath\WebView2Aot.json");
        Console.WriteLine();
    }
}
