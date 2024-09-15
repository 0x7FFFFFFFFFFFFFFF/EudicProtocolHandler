using System;
using System.Diagnostics;
using Microsoft.Win32;
using System.Windows.Forms;

// Compile this code with the following command:
// csc /target:winexe EudicProtocolHandler.cs
class EudicProtocolHandler
{
    [STAThread]
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            HandleUrl(args[0]);
        }
        else
        {
            RegisterProtocol();
            MessageBox.Show("Protocol registered successfully.", "Eudic Protocol Handler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    static void RegisterProtocol()
    {
        string protocolName = "eudic";
        string applicationPath = Application.ExecutablePath;

        using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(protocolName))
        {
            string commandKey = $@"{protocolName}\shell\open\command";
            Registry.ClassesRoot.CreateSubKey(commandKey).SetValue("", 
                $"\"{applicationPath}\" \"%1\"", RegistryValueKind.ExpandString);
            key.SetValue("", $"URL:{protocolName} Protocol");
            key.SetValue("URL Protocol", "");
        }
    }

    static void HandleUrl(string url)
    {
        try
        {
            Uri uri = new Uri(url);
            string[] segments = uri.Segments;

            if (segments.Length > 1)
            {
                string word = segments[segments.Length - 1].TrimEnd('/');
                string eudicPath = @"C:\Program Files\eudic\eudic.exe";
                string arguments = $"-w \"{word}\"";

                Process.Start(eudicPath, arguments);
            }
        }
        catch (Exception)
        {
            // Silently ignore invalid URL
        }
    }
}