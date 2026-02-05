using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Id3.Raw.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Id3.Raw
{
    /// <summary>
    /// API for RawApi
    /// </summary>
    public class RawApi
    {
        private readonly IRawApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the RawApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public RawApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IRawApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of RawApi
        /// </summary>
        public static BitmovinApiBuilder<RawApi> Builder => new BitmovinApiBuilder<RawApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add Raw ID3 Tag to a Progressive TS muxing
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="muxingId">ID of the Progressive TS muxing (required)</param>
        /// <param name="rawId3Tag">The Raw ID3 Tag to be created</param>
        public async Task<Models.RawId3Tag> CreateAsync(string encodingId, string muxingId, Models.RawId3Tag rawId3Tag)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, rawId3Tag);
        }

        /// <summary>
        /// Delete Raw ID3 Tag of a Progressive TS muxing
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="muxingId">ID of the Progressive TS muxing (required)</param>
        /// <param name="id3TagId">ID of the RAW ID3 Tag (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId, string id3TagId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, id3TagId);
        }

        /// <summary>
        /// Raw ID3 Tag Details of a Progressive TS muxing
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="muxingId">ID of the Progressive TS muxing (required)</param>
        /// <param name="id3TagId">ID of the Raw ID3 Tag (required)</param>
        public async Task<Models.RawId3Tag> GetAsync(string encodingId, string muxingId, string id3TagId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, id3TagId);
        }

        /// <summary>
        /// List Raw ID3 Tags of a Progressive TS muxing
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="muxingId">ID of the Progressive TS muxing (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.RawId3Tag>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }

        internal interface IRawApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/id3/raw")]
            [AllowAnyStatusCode]
            Task<Models.RawId3Tag> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.RawId3Tag rawId3Tag);

            [Delete("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/id3/raw/{id3_tag_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("id3_tag_id")] string id3TagId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/id3/raw/{id3_tag_id}")]
            [AllowAnyStatusCode]
            Task<Models.RawId3Tag> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("id3_tag_id")] string id3TagId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/id3/raw")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.RawId3Tag>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
