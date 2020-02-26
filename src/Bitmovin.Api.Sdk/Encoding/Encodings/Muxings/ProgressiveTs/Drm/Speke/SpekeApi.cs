using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Drm.Speke.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Drm.Speke
{
    public class SpekeApi
    {
        private readonly ISpekeApiClient _apiClient;

        public SpekeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISpekeApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SpekeApi
        /// </summary>
        public static BitmovinApiBuilder<SpekeApi> Builder => new BitmovinApiBuilder<SpekeApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add SPEKE DRM key provider to Progressive TS
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive TS muxing (required)</param>
        /// <param name="spekeDrm">The SPEKE DRM key provider to be created</param>
        public async Task<Models.SpekeDrm> CreateAsync(string encodingId, string muxingId, Models.SpekeDrm spekeDrm)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, spekeDrm);
        }

        /// <summary>
        /// Delete SPEKE DRM from Progressive TS
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive TS muxing (required)</param>
        /// <param name="drmId">Id of the SPEKE DRM. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// SPEKE DRM Details of Progressive TS
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive TS muxing (required)</param>
        /// <param name="drmId">Id of the SPEKE DRM. (required)</param>
        public async Task<Models.SpekeDrm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// List SPEKE DRM of Progressive TS
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive TS muxing (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SpekeDrm>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }

        internal interface ISpekeApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/drm/speke")]
            [AllowAnyStatusCode]
            Task<Models.SpekeDrm> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.SpekeDrm spekeDrm);

            [Delete("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/drm/speke/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/drm/speke/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.SpekeDrm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/drm/speke")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SpekeDrm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(string offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(string limit) => SetQueryParam("limit", limit);

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
