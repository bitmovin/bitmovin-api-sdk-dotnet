using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.Details;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.Languages;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.AdPlacements;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId
{
    /// <summary>
    /// API for ByEncodingIdApi
    /// </summary>
    public class ByEncodingIdApi
    {
        /// <summary>
        /// Initializes a new instance of the ByEncodingIdApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ByEncodingIdApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Details = new DetailsApi(apiClientFactory);
            Languages = new LanguagesApi(apiClientFactory);
            AdPlacements = new AdPlacementsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ByEncodingIdApi
        /// </summary>
        public static BitmovinApiBuilder<ByEncodingIdApi> Builder => new BitmovinApiBuilder<ByEncodingIdApi>();

        /// <summary>
        /// Gets the Details API
        /// </summary>
        public DetailsApi Details { get; }
        /// <summary>
        /// Gets the Languages API
        /// </summary>
        public LanguagesApi Languages { get; }
        /// <summary>
        /// Gets the AdPlacements API
        /// </summary>
        public AdPlacementsApi AdPlacements { get; }
    }
}
