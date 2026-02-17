using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Live.Encodings.DnsMappings
{
    /// <summary>
    /// API for DnsMappingsApi
    /// </summary>
    public class DnsMappingsApi
    {
        private readonly IDnsMappingsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DnsMappingsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DnsMappingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDnsMappingsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DnsMappingsApi
        /// </summary>
        public static BitmovinApiBuilder<DnsMappingsApi> Builder => new BitmovinApiBuilder<DnsMappingsApi>();

        /// <summary>
        /// Create new DNS mapping for encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="dnsMappingRequest">The DNS mapping to be created</param>
        public async Task<Models.DnsMappingResponse> CreateAsync(string encodingId, Models.DnsMappingRequest dnsMappingRequest)
        {
            return await _apiClient.CreateAsync(encodingId, dnsMappingRequest);
        }

        /// <summary>
        /// Delete DNS mapping
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="id">Id of the DNS mapping (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string id)
        {
            return await _apiClient.DeleteAsync(encodingId, id);
        }

        /// <summary>
        /// Delete all DNS mappings for encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.BitmovinResponseList> DeleteAllAsync(string encodingId)
        {
            return await _apiClient.DeleteAllAsync(encodingId);
        }

        /// <summary>
        /// DNS mapping details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="id">Id of the DNS mapping (required)</param>
        public async Task<Models.DnsMappingResponse> GetAsync(string encodingId, string id)
        {
            return await _apiClient.GetAsync(encodingId, id);
        }

        /// <summary>
        /// List DNS mappings for encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DnsMappingResponse>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IDnsMappingsApiClient
        {
            [Post("/encoding/live/encodings/{encoding_id}/dns-mappings")]
            [AllowAnyStatusCode]
            Task<Models.DnsMappingResponse> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.DnsMappingRequest dnsMappingRequest);

            [Delete("/encoding/live/encodings/{encoding_id}/dns-mappings/{id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("id")] string id);

            [Delete("/encoding/live/encodings/{encoding_id}/dns-mappings")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponseList> DeleteAllAsync([Path("encoding_id")] string encodingId);

            [Get("/encoding/live/encodings/{encoding_id}/dns-mappings/{id}")]
            [AllowAnyStatusCode]
            Task<Models.DnsMappingResponse> GetAsync([Path("encoding_id")] string encodingId, [Path("id")] string id);

            [Get("/encoding/live/encodings/{encoding_id}/dns-mappings")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DnsMappingResponse>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
