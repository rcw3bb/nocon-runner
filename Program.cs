using System;
using System.Diagnostics;
using System.Text;

namespace nocon_runner
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==0) {
                Console.WriteLine("Usage: nocon-runner <COMMAND> [<ARG1>[ <ARG2>[ <ARGN>]]]");
                return;
            }

            var command = args[0];
            string[] arguments = {};

            StringBuilder sbCommand = new StringBuilder(command);

            if (args.Length > 1) {
                arguments = new string[args.Length - 1];
                Array.Copy(args, 1, arguments, 0, arguments.Length);
                sbCommand.Append(" ");
                sbCommand.Append(String.Join(" ", arguments));
            }

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = command;
            startInfo.Arguments = string.Join(" ", args);
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
