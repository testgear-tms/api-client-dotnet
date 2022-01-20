using System;

using CommandLine;

namespace TestGear.Api.Configuration
{
    [Serializable]
    public class TestGearApiConfig
    {
        [Option("testgear-server-address", Required = false)]
        public string? ServerAddress { get; set; }

        [Option("testgear-private-token", Required = false)]
        public string? PrivateToken { get; set; }

        [Option("testgear-config-file", Required = false)]
        public string? ConfigFile { get; set; }
    }
}
