using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Live.StandbyPools.Logs
{
    public class LogsApi
    {
        private readonly ILogsApiClient _apiClient;

        public LogsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILogsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of LogsApi
        /// </summary>
        public static BitmovinApiBuilder<LogsApi> Builder => new BitmovinApiBuilder<LogsApi>();

        /// <summary>
        /// List event logs for a standby pool
        /// </summary>
        /// <param name="poolId">Id of the standby pool (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.LiveStandbyPoolEventLog>> ListAsync(string poolId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(poolId, q);
        }

        internal interface ILogsApiClient
        {
            [Get("/encoding/live/standby-pools/{pool_id}/logs")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.LiveStandbyPoolEventLog>> ListAsync([Path("pool_id")] string poolId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

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

            /// <summary>
            /// Order list result according a event log attribute.  The fields that can be used for sorting are: + &#x60;createdAt&#x60; + &#x60;eventType&#x60; + &#x60;standByPoolId&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

            /// <summary>
            /// Filter event logs by log type. Allowed values are: + &#x60;INFO&#x60; + &#x60;WARN&#x60; + &#x60;ERROR&#x60; 
            /// </summary>
            public ListQueryParams EventType(string eventType) => SetQueryParam("eventType", eventType);

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
