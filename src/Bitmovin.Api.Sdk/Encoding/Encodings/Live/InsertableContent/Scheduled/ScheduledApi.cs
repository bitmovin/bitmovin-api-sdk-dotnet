using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.InsertableContent.Scheduled
{
    public class ScheduledApi
    {
        private readonly IScheduledApiClient _apiClient;

        public ScheduledApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IScheduledApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of ScheduledApi
        /// </summary>
        public static BitmovinApiBuilder<ScheduledApi> Builder => new BitmovinApiBuilder<ScheduledApi>();

        
        /// <summary>
        /// List All Scheduled Insertable Content For A Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ScheduledInsertableContent>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IScheduledApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/live/insertable-content/scheduled")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ScheduledInsertableContent>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

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
