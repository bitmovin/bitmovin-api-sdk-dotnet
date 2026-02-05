using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Hdr.DolbyVision;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Hdr
{
    /// <summary>
    /// API for HdrApi
    /// </summary>
    public class HdrApi
    {
        /// <summary>
        /// Initializes a new instance of the HdrApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public HdrApi(IBitmovinApiClientFactory apiClientFactory)
        {
            DolbyVision = new DolbyVisionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of HdrApi
        /// </summary>
        public static BitmovinApiBuilder<HdrApi> Builder => new BitmovinApiBuilder<HdrApi>();

        /// <summary>
        /// Gets the DolbyVision API
        /// </summary>
        public DolbyVisionApi DolbyVision { get; }
    }
}
