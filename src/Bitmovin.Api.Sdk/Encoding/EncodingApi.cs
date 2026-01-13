using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings;
using Bitmovin.Api.Sdk.Encoding.Inputs;
using Bitmovin.Api.Sdk.Encoding.Outputs;
using Bitmovin.Api.Sdk.Encoding.Configurations;
using Bitmovin.Api.Sdk.Encoding.Filters;
using Bitmovin.Api.Sdk.Encoding.Live;
using Bitmovin.Api.Sdk.Encoding.Manifests;
using Bitmovin.Api.Sdk.Encoding.Infrastructure;
using Bitmovin.Api.Sdk.Encoding.Statistics;
using Bitmovin.Api.Sdk.Encoding.WatchFolders;
using Bitmovin.Api.Sdk.Encoding.ErrorDefinitions;
using Bitmovin.Api.Sdk.Encoding.Templates;

namespace Bitmovin.Api.Sdk.Encoding
{
    public class EncodingApi
    {
        public EncodingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Encodings = new EncodingsApi(apiClientFactory);
            Inputs = new InputsApi(apiClientFactory);
            Outputs = new OutputsApi(apiClientFactory);
            Configurations = new ConfigurationsApi(apiClientFactory);
            Filters = new FiltersApi(apiClientFactory);
            Live = new LiveApi(apiClientFactory);
            Manifests = new ManifestsApi(apiClientFactory);
            Infrastructure = new InfrastructureApi(apiClientFactory);
            Statistics = new StatisticsApi(apiClientFactory);
            WatchFolders = new WatchFoldersApi(apiClientFactory);
            ErrorDefinitions = new ErrorDefinitionsApi(apiClientFactory);
            Templates = new TemplatesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingApi> Builder => new BitmovinApiBuilder<EncodingApi>();

        public EncodingsApi Encodings { get; }
        public InputsApi Inputs { get; }
        public OutputsApi Outputs { get; }
        public ConfigurationsApi Configurations { get; }
        public FiltersApi Filters { get; }
        public LiveApi Live { get; }
        public ManifestsApi Manifests { get; }
        public InfrastructureApi Infrastructure { get; }
        public StatisticsApi Statistics { get; }
        public WatchFoldersApi WatchFolders { get; }
        public ErrorDefinitionsApi ErrorDefinitions { get; }
        public TemplatesApi Templates { get; }
    }
}
