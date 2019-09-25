using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Information;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Id3;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Drm;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs
{
    public class ProgressiveTsApi
    {
        private readonly IProgressiveTsApiClient _apiClient;

        public ProgressiveTsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IProgressiveTsApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
            Information = new InformationApi(apiClientFactory);
            Id3 = new Id3Api(apiClientFactory);
            Drm = new DrmApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ProgressiveTsApi
        /// </summary>
        public static BitmovinApiBuilder<ProgressiveTsApi> Builder => new BitmovinApiBuilder<ProgressiveTsApi>();

        public CustomdataApi Customdata { get; private set; }
        public InformationApi Information { get; private set; }
        public Id3Api Id3 { get; private set; }
        public DrmApi Drm { get; private set; }
        
        /// <summary>
        /// Add Progressive TS Muxing
        /// </summary>
        /// <param name="encodingId">ID of the encoding.</param>
        /// <param name="progressiveTsMuxing">The request payload</param>
        public async Task<Models.ProgressiveTsMuxing> CreateAsync(string encodingId, Models.ProgressiveTsMuxing progressiveTsMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, progressiveTsMuxing);
        }
        
        /// <summary>
        /// Delete Progressive TS Muxing
        /// </summary>
        /// <param name="encodingId">ID of the Encoding.</param>
        /// <param name="muxingId">ID of the Progressive TS muxing</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// Progressive TS Muxing Details
        /// </summary>
        /// <param name="encodingId">ID of the Encoding.</param>
        /// <param name="muxingId">ID of the Progressive TS Muxing</param>
        public async Task<Models.ProgressiveTsMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// List Progressive TS Muxings
        /// </summary>
        /// <param name="encodingId">ID of the Encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ProgressiveTsMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IProgressiveTsApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/progressive-ts")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveTsMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ProgressiveTsMuxing progressiveTsMuxing);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveTsMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ProgressiveTsMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
