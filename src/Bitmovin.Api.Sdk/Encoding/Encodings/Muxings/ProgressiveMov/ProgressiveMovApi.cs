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
    public class ProgressiveMovApi
    {
        private readonly IProgressiveMovApiClient _apiClient;

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

        public CustomdataApi Customdata { get; private set; }
        public InformationApi Information { get; private set; }
        
        /// <summary>
        /// Add Progressive MOV Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="progressiveMovMuxing">The request payload</param>
        public async Task<Models.ProgressiveMovMuxing> CreateAsync(string encodingId, Models.ProgressiveMovMuxing progressiveMovMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, progressiveMovMuxing);
        }
        
        /// <summary>
        /// Delete Progressive MOV Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the Progressive MOV muxing</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// Progressive MOV Muxing Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the Progressive MOV muxing</param>
        public async Task<Models.ProgressiveMovMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// List Progressive MOV Muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
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
            Task<Models.PaginationResponse<Models.ProgressiveMovMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
