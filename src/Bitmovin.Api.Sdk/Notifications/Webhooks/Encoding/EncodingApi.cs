using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Manifest;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding
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
            Manifest = new ManifestApi(apiClientFactory);
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
        /// Gets the Manifest API
        /// </summary>
        public ManifestApi Manifest { get; }
    }
}
