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
    /// <summary>
    /// API for EncodingApi
    /// </summary>
    public class EncodingApi
    {
        /// <summary>
        /// Initializes a new instance of the EncodingApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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

        /// <summary>
        /// Gets the Encodings API
        /// </summary>
        public EncodingsApi Encodings { get; }
        /// <summary>
        /// Gets the Inputs API
        /// </summary>
        public InputsApi Inputs { get; }
        /// <summary>
        /// Gets the Outputs API
        /// </summary>
        public OutputsApi Outputs { get; }
        /// <summary>
        /// Gets the Configurations API
        /// </summary>
        public ConfigurationsApi Configurations { get; }
        /// <summary>
        /// Gets the Filters API
        /// </summary>
        public FiltersApi Filters { get; }
        /// <summary>
        /// Gets the Live API
        /// </summary>
        public LiveApi Live { get; }
        /// <summary>
        /// Gets the Manifests API
        /// </summary>
        public ManifestsApi Manifests { get; }
        /// <summary>
        /// Gets the Infrastructure API
        /// </summary>
        public InfrastructureApi Infrastructure { get; }
        /// <summary>
        /// Gets the Statistics API
        /// </summary>
        public StatisticsApi Statistics { get; }
        /// <summary>
        /// Gets the WatchFolders API
        /// </summary>
        public WatchFoldersApi WatchFolders { get; }
        /// <summary>
        /// Gets the ErrorDefinitions API
        /// </summary>
        public ErrorDefinitionsApi ErrorDefinitions { get; }
        /// <summary>
        /// Gets the Templates API
        /// </summary>
        public TemplatesApi Templates { get; }
    }
}
