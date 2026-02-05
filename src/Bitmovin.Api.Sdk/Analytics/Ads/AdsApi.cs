using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries;

namespace Bitmovin.Api.Sdk.Analytics.Ads
{
    /// <summary>
    /// API for AdsApi
    /// </summary>
    public class AdsApi
    {
        /// <summary>
        /// Initializes a new instance of the AdsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AdsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Queries = new QueriesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AdsApi
        /// </summary>
        public static BitmovinApiBuilder<AdsApi> Builder => new BitmovinApiBuilder<AdsApi>();

        /// <summary>
        /// Gets the Queries API
        /// </summary>
        public QueriesApi Queries { get; }
    }
}
