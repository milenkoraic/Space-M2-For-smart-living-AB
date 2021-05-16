using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace FactoryManager.AppService.CommandPrompt
{
    public class CommandPromptHelper : ICommandPromptHelper
    {
        public static int ProcessId;
        public static bool IsProcessAlreadyRunning;
        
        public void CheckIfProcessIsAlreadyRunning(string processName)
        {

            if (Process.GetProcessesByName(processName).Length > 0)
            {
                IsProcessAlreadyRunning = true;
                KillProcess(processName);
            }
            else
            {
                IsProcessAlreadyRunning = false;
            }

        }

        public void KillProcess(string processName)

        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName(processName))
                {
                    proc.Kill();
                    Console.WriteLine("Process killed!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Execute(int proccesType, string command)
        {
            ProcessStartInfo pro = new ProcessStartInfo
            {
                WorkingDirectory = @"C:\",
                FileName = "cmd.exe"
            };
            Process proStart = new Process
            {
                StartInfo = pro
            };

            proStart.StartInfo.UseShellExecute = false;
            proStart.StartInfo.RedirectStandardInput = true;
            pro.CreateNoWindow = true;

            proStart.Start();

            StreamWriter commandWriter = proStart.StandardInput;

            ProcessId = proStart.Id;
            try
            {
                switch (proccesType)
                {
                    case 1:
                        //Launch direct command
                        commandWriter.WriteLine(command);
                        break;
                    case 2:
                        //Launch local service by provided path
                        commandWriter.WriteLine("start " + command);
                        break;
                    case 3:
                        //Open web link in default browser
                        commandWriter.WriteLine("start " + '\u0022' + '\u0022' + " " + '\u0022' + command + '\u0022');
                        break;
                }
                foreach (Process proc in Process.GetProcessesByName("cmd.exe"))
                {
                    proc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
