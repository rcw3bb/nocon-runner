using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace nocon_runner
{

    class NoConJson {
        public string Command {get; set;}

        public List<string> Arguments {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==0) {
                var confFile = new FileInfo(Path.Join(".", "conf", "nocon.json"));
                if (confFile.Exists) {
                    var confText = File.ReadAllText(confFile.FullName);
                    var confJson = JsonConvert.DeserializeObject<NoConJson>(confText);
                    var confCommand = confJson.Command;
                    var confArguments = confJson.Arguments;
                    List<string> confData = new List<string>();

                    if (null!=confCommand) {
                        confData.Add(confCommand);
                        if (null!=confArguments) {
                            confArguments.ForEach(  ___arg => {
                                confData.Add(___arg);
                            });
                        }
                    }

                    if (confData.Count > 0) {
                        args = confData.ToArray();
                    }
                }
                else {
                    Console.WriteLine("Usage: nocon-runner <COMMAND> [<ARG1>[ <ARG2>[ <ARGN>]]]");
                    return;
                }
            }

            var command = args[0];
            string[] arguments = {};

            if (args.Length > 1) {
                arguments = new string[args.Length - 1];
                Array.Copy(args, 1, arguments, 0, arguments.Length);
            }

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = command;
            startInfo.Arguments = string.Join(" ", arguments);
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
