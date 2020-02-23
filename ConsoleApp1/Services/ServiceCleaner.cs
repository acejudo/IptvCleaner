using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace IptvCleaner.Services
{
    public class ServiceCleaner : IServiceCleaner
    {
        public const string HTTP = "http";

        public static readonly IList<String> EXTENSIONS = new ReadOnlyCollection<string>
            (new List<String> {
                 "mp4", "mkv", "avi", "null"
            });

        public void CleanIptvFile(string inputFile, string outputFile)
        {
            string[] lines = File.ReadAllLines(inputFile, Encoding.UTF8);

            List<String> channelLines = new List<String>();

            for (int i = 1; i < lines.Length; i++)
            {
                if (lines[i].Contains(HTTP))
                {
                    String extension = lines[i].Substring(lines[i].Length - 3, 3);
                    if(!EXTENSIONS.Contains(extension))
                    {
                        channelLines.Add(lines[i - 1]);
                        channelLines.Add(lines[i]);
                    }
                }
            }

            System.IO.File.WriteAllLines(outputFile, channelLines);
        }
    }
}
