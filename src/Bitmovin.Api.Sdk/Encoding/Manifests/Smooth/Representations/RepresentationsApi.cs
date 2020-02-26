using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Representations.Mp4;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Representations
{
    public class RepresentationsApi
    {
        public RepresentationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Mp4 = new Mp4Api(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of RepresentationsApi
        /// </summary>
        public static BitmovinApiBuilder<RepresentationsApi> Builder => new BitmovinApiBuilder<RepresentationsApi>();

        public Mp4Api Mp4 { get; }
    }
}
