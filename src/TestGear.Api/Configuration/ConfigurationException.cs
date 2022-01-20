using System;

namespace TestGear.Api.Configuration
{
    public class ConfigurationException : Exception
    {
        public ConfigurationException(string propertyName) : base($"Settings option \"{propertyName}\" is missing") { }
    }
}
