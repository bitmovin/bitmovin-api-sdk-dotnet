using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Cdn.Usage
{
    /// <summary>
    /// API for UsageApi
    /// </summary>
    public class UsageApi
    {
        private readonly IUsageApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the UsageApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public UsageApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IUsageApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of UsageApi
        /// </summary>
        public static BitmovinApiBuilder<UsageApi> Builder => new BitmovinApiBuilder<UsageApi>();

        /// <summary>
        /// List CDN usage statistics within specific dates.
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.CdnUsageStatistics> GetAsync(params Func<GetQueryParams, GetQueryParams>[] queryParams)
        {
            GetQueryParams q = new GetQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.GetAsync(q);
        }

        internal interface IUsageApiClient
        {
            [Get("/encoding/statistics/cdn/usage")]
            [AllowAnyStatusCode]
            Task<Models.CdnUsageStatistics> GetAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for Get
        /// </summary>
        public class GetQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Start date. Accepted formats: yyyy-MM-ddThh:mm:ssZ or yyyy-MM-dd
            /// </summary>
            public GetQueryParams From(DateTime? from) => SetQueryParam("from", from);

            /// <summary>
            /// End date. Accepted formats: yyyy-MM-ddThh:mm:ssZ or yyyy-MM-dd
            /// </summary>
            public GetQueryParams To(DateTime? to) => SetQueryParam("to", to);

            private GetQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }
    }
}
