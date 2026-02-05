using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Scc;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions
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
            Scc = new SccApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<CaptionsApi> Builder => new BitmovinApiBuilder<CaptionsApi>();

        /// <summary>
        /// Gets the Scc API
        /// </summary>
        public SccApi Scc { get; }
    }
}
