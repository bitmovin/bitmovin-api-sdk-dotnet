using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Captions.Cea608;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Captions.Cea708;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Captions
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
            Cea608 = new Cea608Api(apiClientFactory);
            Cea708 = new Cea708Api(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<CaptionsApi> Builder => new BitmovinApiBuilder<CaptionsApi>();

        /// <summary>
        /// Gets the Cea608 API
        /// </summary>
        public Cea608Api Cea608 { get; }
        /// <summary>
        /// Gets the Cea708 API
        /// </summary>
        public Cea708Api Cea708 { get; }
    }
}
