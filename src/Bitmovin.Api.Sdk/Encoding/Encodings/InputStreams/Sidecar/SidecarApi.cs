using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Sidecar.DolbyVisionMetadataIngest;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Sidecar
{
    public class SidecarApi
    {
        public SidecarApi(IBitmovinApiClientFactory apiClientFactory)
        {
            DolbyVisionMetadataIngest = new DolbyVisionMetadataIngestApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SidecarApi
        /// </summary>
        public static BitmovinApiBuilder<SidecarApi> Builder => new BitmovinApiBuilder<SidecarApi>();

        public DolbyVisionMetadataIngestApi DolbyVisionMetadataIngest { get; private set; }

    }
}
