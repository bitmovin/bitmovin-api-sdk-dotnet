using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.PackedAudio.Drm.Aes;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.PackedAudio.Drm
{
    /// <summary>
    /// API for DrmApi
    /// </summary>
    public class DrmApi
    {
        /// <summary>
        /// Initializes a new instance of the DrmApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DrmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Aes = new AesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DrmApi
        /// </summary>
        public static BitmovinApiBuilder<DrmApi> Builder => new BitmovinApiBuilder<DrmApi>();

        /// <summary>
        /// Gets the Aes API
        /// </summary>
        public AesApi Aes { get; }
    }
}
