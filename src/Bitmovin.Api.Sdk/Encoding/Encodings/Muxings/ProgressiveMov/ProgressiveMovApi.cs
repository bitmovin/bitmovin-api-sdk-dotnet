using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveMov.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveMov.Information;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveMov
{
    /// <summary>
    /// API for ProgressiveMovApi
    /// </summary>
    public class ProgressiveMovApi
    {
        private readonly IProgressiveMovApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ProgressiveMovApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ProgressiveMovApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IProgressiveMovApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
            Information = new InformationApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ProgressiveMovApi
        /// </summary>
        public static BitmovinApiBuilder<ProgressiveMovApi> Builder => new BitmovinApiBuilder<ProgressiveMovApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }
        /// <summary>
        /// Gets the Information API
        /// </summary>
        public InformationApi Information { get; }

        /// <summary>
        /// Add Progressive MOV muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="progressiveMovMuxing">The Progressive MOV muxing to be created</param>
        public async Task<Models.ProgressiveMovMuxing> CreateAsync(string encodingId, Models.ProgressiveMovMuxing progressiveMovMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, progressiveMovMuxing);
        }

        /// <summary>
        /// Delete Progressive MOV muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive MOV muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// Progressive MOV muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive MOV muxing (required)</param>
        public async Task<Models.ProgressiveMovMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List Progressive MOV muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ProgressiveMovMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IProgressiveMovApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/progressive-mov")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveMovMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ProgressiveMovMuxing progressiveMovMuxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/progressive-mov/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-mov/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveMovMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-mov")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ProgressiveMovMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
