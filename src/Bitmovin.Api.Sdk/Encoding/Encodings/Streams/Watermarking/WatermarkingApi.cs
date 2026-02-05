using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Watermarking.NexguardFileMarker;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Watermarking
{
    /// <summary>
    /// API for WatermarkingApi
    /// </summary>
    public class WatermarkingApi
    {
        /// <summary>
        /// Initializes a new instance of the WatermarkingApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public WatermarkingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            NexguardFileMarker = new NexguardFileMarkerApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WatermarkingApi
        /// </summary>
        public static BitmovinApiBuilder<WatermarkingApi> Builder => new BitmovinApiBuilder<WatermarkingApi>();

        /// <summary>
        /// Gets the NexguardFileMarker API
        /// </summary>
        public NexguardFileMarkerApi NexguardFileMarker { get; }
    }
}
