using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Webm.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Webm.Drm;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Webm
{
    public class WebmApi
    {
        private readonly IWebmApiClient _apiClient;

        public WebmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWebmApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
            Drm = new DrmApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WebmApi
        /// </summary>
        public static BitmovinApiBuilder<WebmApi> Builder => new BitmovinApiBuilder<WebmApi>();

        public CustomdataApi Customdata { get; private set; }
        public DrmApi Drm { get; private set; }
        
        /// <summary>
        /// Add WebM Segment Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="webmMuxing">The request payload</param>
        public async Task<Models.WebmMuxing> CreateAsync(string encodingId, Models.WebmMuxing webmMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, webmMuxing);
        }
        
        /// <summary>
        /// Delete WebM Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the WebM muxing</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// WebM Segment Muxing Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the WebM muxing</param>
        public async Task<Models.WebmMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// List WebM Segment Muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.WebmMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IWebmApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/webm")]
            [AllowAnyStatusCode]
            Task<Models.WebmMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.WebmMuxing webmMuxing);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/webm/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/webm/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.WebmMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/webm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.WebmMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
