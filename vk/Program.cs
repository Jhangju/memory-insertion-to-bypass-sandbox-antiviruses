using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace vk
{
    class Program
    {
        static void Main(string[] args)
        {
            IntPtr pointer = Marshal.AllocHGlobal(1000000000);
            Console.WriteLine(pointer.ToInt32());
            if ((pointer.ToInt32()) > 1)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("ipconfig");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                FileInfo fi = new FileInfo("C:/new.txt");
            }
            else
            {
                Console.WriteLine("hello");
            }
            Console.ReadLine();
        }
    }
}
