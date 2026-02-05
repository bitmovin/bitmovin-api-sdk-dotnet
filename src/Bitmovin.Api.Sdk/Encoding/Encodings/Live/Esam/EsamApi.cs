using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Live.Esam.MediaPoints;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.Esam
{
    /// <summary>
    /// API for EsamApi
    /// </summary>
    public class EsamApi
    {
        /// <summary>
        /// Initializes a new instance of the EsamApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public EsamApi(IBitmovinApiClientFactory apiClientFactory)
        {
            MediaPoints = new MediaPointsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EsamApi
        /// </summary>
        public static BitmovinApiBuilder<EsamApi> Builder => new BitmovinApiBuilder<EsamApi>();

        /// <summary>
        /// Gets the MediaPoints API
        /// </summary>
        public MediaPointsApi MediaPoints { get; }
    }
}
