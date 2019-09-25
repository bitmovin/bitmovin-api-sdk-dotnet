using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries;

namespace Bitmovin.Api.Sdk.Analytics.Ads
{
    public class AdsApi
    {
        public AdsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Queries = new QueriesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AdsApi
        /// </summary>
        public static BitmovinApiBuilder<AdsApi> Builder => new BitmovinApiBuilder<AdsApi>();

        public QueriesApi Queries { get; private set; }

    }
}
