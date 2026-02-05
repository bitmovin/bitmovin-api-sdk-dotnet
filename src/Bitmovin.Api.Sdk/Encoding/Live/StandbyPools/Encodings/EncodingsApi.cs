using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Live.StandbyPools.Encodings
{
    /// <summary>
    /// API for EncodingsApi
    /// </summary>
    public class EncodingsApi
    {
        private readonly IEncodingsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the EncodingsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public EncodingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEncodingsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingsApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingsApi> Builder => new BitmovinApiBuilder<EncodingsApi>();

        /// <summary>
        /// Delete encoding from pool by id
        /// </summary>
        /// <param name="poolId">Id of the standby pool (required)</param>
        /// <param name="id">Id of the standby pool encoding (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string poolId, string id)
        {
            return await _apiClient.DeleteAsync(poolId, id);
        }

        /// <summary>
        /// List encodings from a standby pool
        /// </summary>
        /// <param name="poolId">Id of the standby pool (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.LiveStandbyPoolEncoding>> ListAsync(string poolId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(poolId, q);
        }

        internal interface IEncodingsApiClient
        {
            [Delete("/encoding/live/standby-pools/{pool_id}/encodings/{id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("pool_id")] string poolId, [Path("id")] string id);

            [Get("/encoding/live/standby-pools/{pool_id}/encodings")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.LiveStandbyPoolEncoding>> ListAsync([Path("pool_id")] string poolId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

            /// <summary>
            /// Order list result according a stream key attribute.  The fields that can be used for sorting are: + &#x60;createdAt&#x60; + &#x60;name&#x60; + &#x60;status&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

            /// <summary>
            /// Filter standby encodings by status
            /// </summary>
            public ListQueryParams Status(string status) => SetQueryParam("status", status);

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
