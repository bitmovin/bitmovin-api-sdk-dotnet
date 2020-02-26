using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm.Information;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm.Drm;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm
{
    public class ProgressiveWebmApi
    {
        private readonly IProgressiveWebmApiClient _apiClient;

        public ProgressiveWebmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IProgressiveWebmApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
            Information = new InformationApi(apiClientFactory);
            Drm = new DrmApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ProgressiveWebmApi
        /// </summary>
        public static BitmovinApiBuilder<ProgressiveWebmApi> Builder => new BitmovinApiBuilder<ProgressiveWebmApi>();

        public CustomdataApi Customdata { get; }
        public InformationApi Information { get; }
        public DrmApi Drm { get; }

        /// <summary>
        /// Add Progressive WebM muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="progressiveWebmMuxing">The Progressive WebM muxing to be created</param>
        public async Task<Models.ProgressiveWebmMuxing> CreateAsync(string encodingId, Models.ProgressiveWebmMuxing progressiveWebmMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, progressiveWebmMuxing);
        }

        /// <summary>
        /// Delete Progressive WebM muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive WebM muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// Progressive WebM muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive WebM muxing (required)</param>
        public async Task<Models.ProgressiveWebmMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List Progressive WebM muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ProgressiveWebmMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IProgressiveWebmApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/progressive-webm")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveWebmMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ProgressiveWebmMuxing progressiveWebmMuxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/progressive-webm/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-webm/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveWebmMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-webm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ProgressiveWebmMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
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
