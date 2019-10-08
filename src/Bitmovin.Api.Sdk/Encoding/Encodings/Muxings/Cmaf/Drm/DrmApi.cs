using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm.Speke;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm
{
    public class DrmApi
    {
        public DrmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Speke = new SpekeApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DrmApi
        /// </summary>
        public static BitmovinApiBuilder<DrmApi> Builder => new BitmovinApiBuilder<DrmApi>();

        public SpekeApi Speke { get; private set; }

    }
}
