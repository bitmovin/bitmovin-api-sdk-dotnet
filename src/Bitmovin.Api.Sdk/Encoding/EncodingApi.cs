using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs;
using Bitmovin.Api.Sdk.Encoding.Outputs;
using Bitmovin.Api.Sdk.Encoding.Configurations;
using Bitmovin.Api.Sdk.Encoding.Filters;
using Bitmovin.Api.Sdk.Encoding.Encodings;
using Bitmovin.Api.Sdk.Encoding.Manifests;
using Bitmovin.Api.Sdk.Encoding.Infrastructure;
using Bitmovin.Api.Sdk.Encoding.Statistics;
using Bitmovin.Api.Sdk.Encoding.ErrorDefinitions;

namespace Bitmovin.Api.Sdk.Encoding
{
    public class EncodingApi
    {
        public EncodingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Inputs = new InputsApi(apiClientFactory);
            Outputs = new OutputsApi(apiClientFactory);
            Configurations = new ConfigurationsApi(apiClientFactory);
            Filters = new FiltersApi(apiClientFactory);
            Encodings = new EncodingsApi(apiClientFactory);
            Manifests = new ManifestsApi(apiClientFactory);
            Infrastructure = new InfrastructureApi(apiClientFactory);
            Statistics = new StatisticsApi(apiClientFactory);
            ErrorDefinitions = new ErrorDefinitionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingApi> Builder => new BitmovinApiBuilder<EncodingApi>();

        public InputsApi Inputs { get; private set; }
        public OutputsApi Outputs { get; private set; }
        public ConfigurationsApi Configurations { get; private set; }
        public FiltersApi Filters { get; private set; }
        public EncodingsApi Encodings { get; private set; }
        public ManifestsApi Manifests { get; private set; }
        public InfrastructureApi Infrastructure { get; private set; }
        public StatisticsApi Statistics { get; private set; }
        public ErrorDefinitionsApi ErrorDefinitions { get; private set; }

    }
}
