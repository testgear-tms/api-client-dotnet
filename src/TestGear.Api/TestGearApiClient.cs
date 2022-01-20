using System;
using System.IO;
using System.Net.Http;

using CommandLine;

using Newtonsoft.Json;

using TestGear.Api.Configuration;

namespace TestGear.Api
{
    public class TestGearApiClient : IDisposable
    {
        private const string ServerAddressEnv = "TESTGEAR_SERVER_ADDRESS";
        private const string PrivateTokenEnv = "TESTGEAR_PRIVATE_TOKEN";
        private const string ConfigFileEnv = "TESTGEAR_CONFIG_FILE";

        private readonly HttpClient _httpClient;

        public TestGearApiClient() : this(default(TestGearApiConfig)) { }

        public TestGearApiClient(string configFile) :
            this(new TestGearApiConfig { ConfigFile = configFile }) { }

        public TestGearApiClient(TestGearApiConfig? config)
        {
            config ??= new TestGearApiConfig();
            EnrichFromFile(config, config.ConfigFile);
            EnrichFromEnv(config);
            EnrichFromCli(config);

            if (string.IsNullOrWhiteSpace(config.ServerAddress))
                throw new ConfigurationException(nameof(config.ServerAddress));

            if (string.IsNullOrWhiteSpace(config.PrivateToken))
                throw new ConfigurationException(nameof(config.PrivateToken));

            _httpClient = InitializeHttpClient(config);

            Attachments = new AttachmentsClient(_httpClient);
            AutoTests = new AutoTestsClient(_httpClient);
            Configurations = new ConfigurationsClient(_httpClient);
            Parameters = new ParametersClient(_httpClient);
            Projects = new ProjectsClient(_httpClient);
            Sections = new SectionsClient(_httpClient);
            TestPlans = new TestPlansClient(_httpClient);
            TestResults = new TestResultsClient(_httpClient);
            TestRuns = new TestRunsClient(_httpClient);
            TestSuites = new TestSuitesClient(_httpClient);
            WorkItems = new WorkItemsClient(_httpClient);
        }

        public AttachmentsClient Attachments { get; }
        public AutoTestsClient AutoTests { get; }
        public ConfigurationsClient Configurations { get; }
        public ParametersClient Parameters { get; }
        public ProjectsClient Projects { get; }
        public SectionsClient Sections { get; }
        public TestPlansClient TestPlans { get; }
        public TestResultsClient TestResults { get; }
        public TestRunsClient TestRuns { get; }
        public TestSuitesClient TestSuites { get; }
        public WorkItemsClient WorkItems { get; }

        public void Dispose()
        {
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
        }

        private static HttpClient InitializeHttpClient(TestGearApiConfig config)
        {
            var apiUri = new Uri(config.ServerAddress!);

            var httpClient = new HttpClient
            {
                BaseAddress = apiUri,
                DefaultRequestHeaders =
                {
                    { "Authorization", $"PrivateToken {config.PrivateToken!}" }
                }
            };

            return httpClient;
        }

        private static void MergeConfigurations(TestGearApiConfig target, TestGearApiConfig additional)
        {
            target.ServerAddress = additional.ServerAddress ?? target.ServerAddress;
            target.PrivateToken = additional.PrivateToken ?? target.PrivateToken;
        }

        private static void EnrichFromFile(TestGearApiConfig config, string? file)
        {
            if (file is null)
                return;

            if (!File.Exists(file))
                return;

            var configFileData = File.ReadAllText(file);

            TestGearApiConfig parsedConfig;

            try
            {
                parsedConfig = JsonConvert.DeserializeObject<TestGearApiConfig>(configFileData)
                    ?? throw new JsonSerializationException();
            }
            catch (JsonSerializationException)
            {
                return;
            }

            MergeConfigurations(config, parsedConfig);
        }

        private static void EnrichFromEnv(TestGearApiConfig config)
        {
            var host = Environment.GetEnvironmentVariable(ServerAddressEnv);
            var privateToken = Environment.GetEnvironmentVariable(PrivateTokenEnv);
            var configFile = Environment.GetEnvironmentVariable(ConfigFileEnv);

            var parsedConfig = new TestGearApiConfig
            {
                ServerAddress = host,
                PrivateToken = privateToken,
                ConfigFile = configFile
            };

            EnrichFromFile(config, parsedConfig.ConfigFile);
            MergeConfigurations(config, parsedConfig);
        }

        private static void EnrichFromCli(TestGearApiConfig config)
        {
            var parsedConfig = new TestGearApiConfig();

            Parser.Default
               .ParseArguments<TestGearApiConfig>(Environment.GetCommandLineArgs())
               .WithParsed(c => parsedConfig = c);

            EnrichFromFile(config, parsedConfig.ConfigFile);
            MergeConfigurations(config, parsedConfig);
        }
    }
}
