using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Live.Encodings.Actions;
using Bitmovin.Api.Sdk.Encoding.Live.Encodings.DnsMappings;

namespace Bitmovin.Api.Sdk.Encoding.Live.Encodings
{
    /// <summary>
    /// API for EncodingsApi
    /// </summary>
    public class EncodingsApi
    {
        /// <summary>
        /// Initializes a new instance of the EncodingsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public EncodingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Actions = new ActionsApi(apiClientFactory);
            DnsMappings = new DnsMappingsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingsApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingsApi> Builder => new BitmovinApiBuilder<EncodingsApi>();

        /// <summary>
        /// Gets the Actions API
        /// </summary>
        public ActionsApi Actions { get; }
        /// <summary>
        /// Gets the DnsMappings API
        /// </summary>
        public DnsMappingsApi DnsMappings { get; }
    }
}
