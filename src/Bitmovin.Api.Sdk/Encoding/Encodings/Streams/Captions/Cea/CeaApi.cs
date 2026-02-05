using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea.Scc;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea.Srt;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea
{
    /// <summary>
    /// API for CeaApi
    /// </summary>
    public class CeaApi
    {
        /// <summary>
        /// Initializes a new instance of the CeaApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CeaApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Scc = new SccApi(apiClientFactory);
            Srt = new SrtApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CeaApi
        /// </summary>
        public static BitmovinApiBuilder<CeaApi> Builder => new BitmovinApiBuilder<CeaApi>();

        /// <summary>
        /// Gets the Scc API
        /// </summary>
        public SccApi Scc { get; }
        /// <summary>
        /// Gets the Srt API
        /// </summary>
        public SrtApi Srt { get; }
    }
}
