using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.SegmentedRaw.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.SegmentedRaw
{
    public class SegmentedRawApi
    {
        private readonly ISegmentedRawApiClient _apiClient;

        public SegmentedRawApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISegmentedRawApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SegmentedRawApi
        /// </summary>
        public static BitmovinApiBuilder<SegmentedRawApi> Builder => new BitmovinApiBuilder<SegmentedRawApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add Segmented RAW muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="segmentedRawMuxing">The Segmented RAW muxing to be created</param>
        public async Task<Models.SegmentedRawMuxing> CreateAsync(string encodingId, Models.SegmentedRawMuxing segmentedRawMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, segmentedRawMuxing);
        }

        /// <summary>
        /// Delete Segmented RAW muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Segmented RAW muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// Segmented RAW muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Segmented RAW muxing (required)</param>
        public async Task<Models.SegmentedRawMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List Segmented RAW muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SegmentedRawMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface ISegmentedRawApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/segmented-raw")]
            [AllowAnyStatusCode]
            Task<Models.SegmentedRawMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.SegmentedRawMuxing segmentedRawMuxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/segmented-raw/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/segmented-raw/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.SegmentedRawMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/segmented-raw")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SegmentedRawMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
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
