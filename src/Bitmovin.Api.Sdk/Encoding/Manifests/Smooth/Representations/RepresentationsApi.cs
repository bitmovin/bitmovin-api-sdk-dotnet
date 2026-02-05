using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Representations.Mp4;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Representations
{
    /// <summary>
    /// API for RepresentationsApi
    /// </summary>
    public class RepresentationsApi
    {
        /// <summary>
        /// Initializes a new instance of the RepresentationsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public RepresentationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Mp4 = new Mp4Api(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of RepresentationsApi
        /// </summary>
        public static BitmovinApiBuilder<RepresentationsApi> Builder => new BitmovinApiBuilder<RepresentationsApi>();

        /// <summary>
        /// Gets the Mp4 API
        /// </summary>
        public Mp4Api Mp4 { get; }
    }
}
