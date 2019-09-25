using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics.Srt
{
    public class SrtApi
    {
        private readonly ISrtApiClient _apiClient;

        public SrtApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISrtApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of SrtApi
        /// </summary>
        public static BitmovinApiBuilder<SrtApi> Builder => new BitmovinApiBuilder<SrtApi>();

        
        /// <summary>
        /// List Stream Infos of Live Statistics from an Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SrtStatistics>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        /// <summary>
        /// List Statistics For SRT Live Stream Input
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="srtInputId">Id of the SRT input.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SrtStatistics>> ListBySrtInputIdAsync(string encodingId, string srtInputId, params Func<ListBySrtInputIdQueryParams, ListBySrtInputIdQueryParams>[] queryParams)
        {
            ListBySrtInputIdQueryParams q = new ListBySrtInputIdQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListBySrtInputIdAsync(encodingId, srtInputId, q);
        }
        
        internal interface ISrtApiClient
        {
            
            [Get("/encoding/statistics/encodings/{encoding_id}/live-statistics/srt")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SrtStatistics>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
            [Get("/encoding/statistics/encodings/{encoding_id}/live-statistics/srt/{srt_input_id}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SrtStatistics>> ListBySrtInputIdAsync([Path("encoding_id")] string encodingId, [Path("srt_input_id")] string srtInputId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
        public class ListBySrtInputIdQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListBySrtInputIdQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListBySrtInputIdQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

            private ListBySrtInputIdQueryParams SetQueryParam<T>(string key, T value)
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
