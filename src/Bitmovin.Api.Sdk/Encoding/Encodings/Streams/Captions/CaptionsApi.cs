using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions
{
    /// <summary>
    /// API for CaptionsApi
    /// </summary>
    public class CaptionsApi
    {
        /// <summary>
        /// Initializes a new instance of the CaptionsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CaptionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Cea = new CeaApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<CaptionsApi> Builder => new BitmovinApiBuilder<CaptionsApi>();

        /// <summary>
        /// Gets the Cea API
        /// </summary>
        public CeaApi Cea { get; }
    }
}
