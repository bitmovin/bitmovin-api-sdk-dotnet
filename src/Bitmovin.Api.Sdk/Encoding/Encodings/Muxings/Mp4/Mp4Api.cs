using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Information;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4
{
    public class Mp4Api
    {
        private readonly IMp4ApiClient _apiClient;

        public Mp4Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMp4ApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
            Information = new InformationApi(apiClientFactory);
            Drm = new DrmApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Mp4Api
        /// </summary>
        public static BitmovinApiBuilder<Mp4Api> Builder => new BitmovinApiBuilder<Mp4Api>();

        public CustomdataApi Customdata { get; private set; }
        public InformationApi Information { get; private set; }
        public DrmApi Drm { get; private set; }
        
        /// <summary>
        /// Add MP4 Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="mp4Muxing">The request payload</param>
        public async Task<Models.Mp4Muxing> CreateAsync(string encodingId, Models.Mp4Muxing mp4Muxing)
        {
            return await _apiClient.CreateAsync(encodingId, mp4Muxing);
        }
        
        /// <summary>
        /// Delete MP4 Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the MP4 muxing</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// MP4 Segment Muxing Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the MP4 muxing</param>
        public async Task<Models.Mp4Muxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// List MP4 Muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Mp4Muxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IMp4ApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/mp4")]
            [AllowAnyStatusCode]
            Task<Models.Mp4Muxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Mp4Muxing mp4Muxing);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.Mp4Muxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/mp4")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Mp4Muxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
