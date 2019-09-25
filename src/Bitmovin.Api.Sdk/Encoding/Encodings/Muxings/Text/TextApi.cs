using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Text.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Text
{
    public class TextApi
    {
        private readonly ITextApiClient _apiClient;

        public TextApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITextApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of TextApi
        /// </summary>
        public static BitmovinApiBuilder<TextApi> Builder => new BitmovinApiBuilder<TextApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Add Text Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="textMuxing">The request payload</param>
        public async Task<Models.TextMuxing> CreateAsync(string encodingId, Models.TextMuxing textMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, textMuxing);
        }
        
        /// <summary>
        /// Delete Text Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the Text muxing</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// Text Muxing Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the Text muxing</param>
        public async Task<Models.TextMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// List Text Muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.TextMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface ITextApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/text")]
            [AllowAnyStatusCode]
            Task<Models.TextMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.TextMuxing textMuxing);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/text/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/text/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.TextMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/text")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TextMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
