using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Emails.UsageReports
{
    /// <summary>
    /// API for UsageReportsApi
    /// </summary>
    public class UsageReportsApi
    {
        private readonly IUsageReportsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the UsageReportsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public UsageReportsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IUsageReportsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of UsageReportsApi
        /// </summary>
        public static BitmovinApiBuilder<UsageReportsApi> Builder => new BitmovinApiBuilder<UsageReportsApi>();

        /// <summary>
        /// List Email Notifications (All Usage Reports)
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.EmailNotification>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IUsageReportsApiClient
        {
            [Get("/notifications/emails/usage-reports")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EmailNotification>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private ListQueryParams SetQueryParam<T>(string key, T value)
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
