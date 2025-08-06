using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.Details;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.Languages;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId
{
    public class ByEncodingIdApi
    {
        public ByEncodingIdApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Details = new DetailsApi(apiClientFactory);
            Languages = new LanguagesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ByEncodingIdApi
        /// </summary>
        public static BitmovinApiBuilder<ByEncodingIdApi> Builder => new BitmovinApiBuilder<ByEncodingIdApi>();

        public DetailsApi Details { get; }
        public LanguagesApi Languages { get; }
    }
}
