using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Sidecar.DolbyVisionMetadataIngest;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Sidecar
{
    /// <summary>
    /// API for SidecarApi
    /// </summary>
    public class SidecarApi
    {
        /// <summary>
        /// Initializes a new instance of the SidecarApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SidecarApi(IBitmovinApiClientFactory apiClientFactory)
        {
            DolbyVisionMetadataIngest = new DolbyVisionMetadataIngestApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SidecarApi
        /// </summary>
        public static BitmovinApiBuilder<SidecarApi> Builder => new BitmovinApiBuilder<SidecarApi>();

        /// <summary>
        /// Gets the DolbyVisionMetadataIngest API
        /// </summary>
        public DolbyVisionMetadataIngestApi DolbyVisionMetadataIngest { get; }
    }
}
