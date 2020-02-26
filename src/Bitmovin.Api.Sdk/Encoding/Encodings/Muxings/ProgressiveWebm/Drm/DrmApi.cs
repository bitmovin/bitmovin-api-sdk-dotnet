using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm.Drm.Cenc;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm.Drm.Speke;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm.Drm
{
    public class DrmApi
    {
        public DrmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Cenc = new CencApi(apiClientFactory);
            Speke = new SpekeApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DrmApi
        /// </summary>
        public static BitmovinApiBuilder<DrmApi> Builder => new BitmovinApiBuilder<DrmApi>();

        public CencApi Cenc { get; }
        public SpekeApi Speke { get; }
    }
}
