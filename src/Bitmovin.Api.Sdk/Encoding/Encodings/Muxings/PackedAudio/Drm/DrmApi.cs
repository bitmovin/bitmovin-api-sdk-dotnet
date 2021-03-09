using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.PackedAudio.Drm.Aes;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.PackedAudio.Drm
{
    public class DrmApi
    {
        public DrmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Aes = new AesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DrmApi
        /// </summary>
        public static BitmovinApiBuilder<DrmApi> Builder => new BitmovinApiBuilder<DrmApi>();

        public AesApi Aes { get; }
    }
}
