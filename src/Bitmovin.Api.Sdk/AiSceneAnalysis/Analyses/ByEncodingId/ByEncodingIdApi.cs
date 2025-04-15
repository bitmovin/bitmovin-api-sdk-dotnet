using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.Details;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId
{
    public class ByEncodingIdApi
    {
        public ByEncodingIdApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Details = new DetailsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ByEncodingIdApi
        /// </summary>
        public static BitmovinApiBuilder<ByEncodingIdApi> Builder => new BitmovinApiBuilder<ByEncodingIdApi>();

        public DetailsApi Details { get; }
    }
}
