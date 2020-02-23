using System;

namespace IptvCleaner.Services
{
    public interface IServiceCleaner
    {
        void CleanIptvFile(String inputFile, String outputFile);
    }
}
