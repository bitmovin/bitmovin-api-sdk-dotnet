using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Concatenation
{
    public class ConcatenationApi
    {
        private readonly IConcatenationApiClient _apiClient;

        public ConcatenationApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IConcatenationApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ConcatenationApi
        /// </summary>
        public static BitmovinApiBuilder<ConcatenationApi> Builder => new BitmovinApiBuilder<ConcatenationApi>();

        /// <summary>
        /// Add Concatenation Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="concatenationInputStream">The Concatenation Input Stream to be created</param>
        public async Task<Models.ConcatenationInputStream> CreateAsync(string encodingId, Models.ConcatenationInputStream concatenationInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, concatenationInputStream);
        }

        /// <summary>
        /// Delete Concatenation Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the Concatenation input stream. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// Concatenation Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the concatenation input stream. (required)</param>
        public async Task<Models.ConcatenationInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// List Concatenation Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ConcatenationInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IConcatenationApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/input-streams/concatenation")]
            [AllowAnyStatusCode]
            Task<Models.ConcatenationInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ConcatenationInputStream concatenationInputStream);

            [Delete("/encoding/encodings/{encoding_id}/input-streams/concatenation/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/concatenation/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.ConcatenationInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/concatenation")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ConcatenationInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
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
