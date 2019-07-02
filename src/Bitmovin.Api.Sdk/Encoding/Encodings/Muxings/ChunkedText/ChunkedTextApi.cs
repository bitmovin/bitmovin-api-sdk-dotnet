﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ChunkedText.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ChunkedText
{
    public class ChunkedTextApi
    {
        private readonly IChunkedTextApiClient _apiClient;

        public ChunkedTextApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IChunkedTextApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ChunkedTextApi
        /// </summary>
        public static BitmovinApiBuilder<ChunkedTextApi> Builder => new BitmovinApiBuilder<ChunkedTextApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Add Chunked Text Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="chunkedTextMuxing">The request payload</param>
        public async Task<Models.ChunkedTextMuxing> CreateAsync(string encodingId, Models.ChunkedTextMuxing chunkedTextMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, chunkedTextMuxing);
        }
        
        /// <summary>
        /// Delete Chunked Text Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the Chunked Text Muxing</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// Chunked Text Muxing Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the Chunked Text Muxing</param>
        public async Task<Models.ChunkedTextMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// List Chunked Text Muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ChunkedTextMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IChunkedTextApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/chunked-text")]
            [AllowAnyStatusCode]
            Task<Models.ChunkedTextMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ChunkedTextMuxing chunkedTextMuxing);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/chunked-text/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/chunked-text/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.ChunkedTextMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/chunked-text")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ChunkedTextMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
