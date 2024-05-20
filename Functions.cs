using System;
using System.Diagnostics;
using System.IO;
namespace Functions;
public class Function
{
    // to open insta
    public static void OpenLink(string link)
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            });
        }
        catch
        {
            Console.WriteLine("Couldn't Open Instgram");
        }
    }
    // to delete the files
    public static void CleanUp()
    {
        string pcuser = Environment.UserName;

        string temp1 = @$"C:\Users\{pcuser}\AppData\Local\Temp";
        string temp2 = @"C:\Windows\Temp";
        string prefetch = @"C:\Windows\Prefetch";

        CleanDirectory(temp1);
        CleanDirectory(temp2);
        CleanDirectory(prefetch);

         static void CleanDirectory(string directoryPath)
        {

            // Delete files
            foreach (string file in Directory.GetFiles(directoryPath))
            {
                try
                {
                File.Delete(file);
                } catch
                {
                }
            }

            // Delete subdirectories
            foreach (string subdirectory in Directory.GetDirectories(directoryPath))
            {
                try
                {
                Directory.Delete(subdirectory, true);
                } 
                catch
                { 
                }
            }
        }


    }
}
