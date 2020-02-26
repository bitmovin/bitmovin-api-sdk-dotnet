using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Hdr.DolbyVision;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Hdr
{
    public class HdrApi
    {
        public HdrApi(IBitmovinApiClientFactory apiClientFactory)
        {
            DolbyVision = new DolbyVisionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of HdrApi
        /// </summary>
        public static BitmovinApiBuilder<HdrApi> Builder => new BitmovinApiBuilder<HdrApi>();

        public DolbyVisionApi DolbyVision { get; }
    }
}
