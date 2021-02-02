using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Watermarking.NexguardFileMarker;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Watermarking
{
    public class WatermarkingApi
    {
        public WatermarkingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            NexguardFileMarker = new NexguardFileMarkerApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WatermarkingApi
        /// </summary>
        public static BitmovinApiBuilder<WatermarkingApi> Builder => new BitmovinApiBuilder<WatermarkingApi>();

        public NexguardFileMarkerApi NexguardFileMarker { get; }
    }
}
