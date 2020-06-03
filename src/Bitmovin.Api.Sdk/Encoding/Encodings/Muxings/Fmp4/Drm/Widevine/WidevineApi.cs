using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Widevine.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Widevine
{
    public class WidevineApi
    {
        private readonly IWidevineApiClient _apiClient;

        public WidevineApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWidevineApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WidevineApi
        /// </summary>
        public static BitmovinApiBuilder<WidevineApi> Builder => new BitmovinApiBuilder<WidevineApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add Widevine DRM to an fMP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the fMP4 muxing. (required)</param>
        /// <param name="widevineDrm">The Widevine DRM to be created</param>
        public async Task<Models.WidevineDrm> CreateAsync(string encodingId, string muxingId, Models.WidevineDrm widevineDrm)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, widevineDrm);
        }

        /// <summary>
        /// Delete Widevine DRM from an fMP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the fMP4 muxing (required)</param>
        /// <param name="drmId">Id of the widevine drm. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// Widevine DRM Details of an fMP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the fMP4 muxing. (required)</param>
        /// <param name="drmId">Id of the widevine drm. (required)</param>
        public async Task<Models.WidevineDrm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// List Widevine DRMs of an fMP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the fMP4 muxing (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.WidevineDrm>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }

        internal interface IWidevineApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm/widevine")]
            [AllowAnyStatusCode]
            Task<Models.WidevineDrm> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.WidevineDrm widevineDrm);

            [Delete("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm/widevine/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm/widevine/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.WidevineDrm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm/widevine")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.WidevineDrm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap] IDictionary<String, Object> queryParams);
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
