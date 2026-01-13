using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Live.Esam.MediaPoints;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.Esam
{
    public class EsamApi
    {
        public EsamApi(IBitmovinApiClientFactory apiClientFactory)
        {
            MediaPoints = new MediaPointsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EsamApi
        /// </summary>
        public static BitmovinApiBuilder<EsamApi> Builder => new BitmovinApiBuilder<EsamApi>();

        public MediaPointsApi MediaPoints { get; }
    }
}
