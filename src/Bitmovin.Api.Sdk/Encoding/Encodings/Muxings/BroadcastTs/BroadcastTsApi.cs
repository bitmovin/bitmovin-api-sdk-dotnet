using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.BroadcastTs.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.BroadcastTs.Information;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.BroadcastTs
{
    /// <summary>
    /// API for BroadcastTsApi
    /// </summary>
    public class BroadcastTsApi
    {
        private readonly IBroadcastTsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the BroadcastTsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public BroadcastTsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IBroadcastTsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
            Information = new InformationApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of BroadcastTsApi
        /// </summary>
        public static BitmovinApiBuilder<BroadcastTsApi> Builder => new BitmovinApiBuilder<BroadcastTsApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }
        /// <summary>
        /// Gets the Information API
        /// </summary>
        public InformationApi Information { get; }

        /// <summary>
        /// Add Broadcast TS muxing
        /// </summary>
        /// <param name="encodingId">ID of the encoding. (required)</param>
        /// <param name="broadcastTsMuxing">The Broadcast TS muxing to be created</param>
        public async Task<Models.BroadcastTsMuxing> CreateAsync(string encodingId, Models.BroadcastTsMuxing broadcastTsMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, broadcastTsMuxing);
        }

        /// <summary>
        /// Delete Broadcast TS muxing
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="muxingId">ID of the Broadcast TS muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// Broadcast TS muxing details
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="muxingId">ID of the Broadcast TS muxing (required)</param>
        public async Task<Models.BroadcastTsMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List Broadcast TS muxings
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.BroadcastTsMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IBroadcastTsApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/broadcast-ts")]
            [AllowAnyStatusCode]
            Task<Models.BroadcastTsMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.BroadcastTsMuxing broadcastTsMuxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/broadcast-ts/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/broadcast-ts/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BroadcastTsMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/broadcast-ts")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.BroadcastTsMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
