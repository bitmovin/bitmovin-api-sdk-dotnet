using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Webvtt.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Webvtt
{
    public class WebvttApi
    {
        private readonly IWebvttApiClient _apiClient;

        public WebvttApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWebvttApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WebvttApi
        /// </summary>
        public static BitmovinApiBuilder<WebvttApi> Builder => new BitmovinApiBuilder<WebvttApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Extract WebVtt Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="webVttExtract">The request payload</param>
        public async Task<Models.WebVttExtract> CreateAsync(string encodingId, Models.WebVttExtract webVttExtract)
        {
            return await _apiClient.CreateAsync(encodingId, webVttExtract);
        }
        
        /// <summary>
        /// Delete Extract WebVtt Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="captionsId">Id of the captions configuration.</param>
        public async Task<Models.WebVttExtract> DeleteAsync(string encodingId, string captionsId)
        {
            return await _apiClient.DeleteAsync(encodingId, captionsId);
        }
        
        /// <summary>
        /// Get Extract WebVtt Captions Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="captionsId">Id of the captions.</param>
        public async Task<Models.WebVttExtract> GetAsync(string encodingId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, captionsId);
        }
        
        /// <summary>
        /// List Extract WebVtt Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.WebVttExtract>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IWebvttApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/captions/extract/webvtt")]
            [AllowAnyStatusCode]
            Task<Models.WebVttExtract> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.WebVttExtract webVttExtract);
            
            [Delete("/encoding/encodings/{encoding_id}/captions/extract/webvtt/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.WebVttExtract> DeleteAsync([Path("encoding_id")] string encodingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/extract/webvtt/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.WebVttExtract> GetAsync([Path("encoding_id")] string encodingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/extract/webvtt")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.WebVttExtract>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
