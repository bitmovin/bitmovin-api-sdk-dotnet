using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm.Marlin.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm.Marlin
{
    public class MarlinApi
    {
        private readonly IMarlinApiClient _apiClient;

        public MarlinApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMarlinApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MarlinApi
        /// </summary>
        public static BitmovinApiBuilder<MarlinApi> Builder => new BitmovinApiBuilder<MarlinApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add Marlin DRM to an MP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the MP4 muxing. (required)</param>
        /// <param name="marlinDrm">The Marlin DRM to be created</param>
        public async Task<Models.MarlinDrm> CreateAsync(string encodingId, string muxingId, Models.MarlinDrm marlinDrm)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, marlinDrm);
        }

        /// <summary>
        /// Delete Marlin DRM from an MP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the mp4. (required)</param>
        /// <param name="drmId">Id of the Marlin DRM configuration. (required)</param>
        public async Task<Models.MarlinDrm> DeleteAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// Marlin DRM Details of an MP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the mp4. (required)</param>
        /// <param name="drmId">Id of the Marlin DRM configuration. (required)</param>
        public async Task<Models.MarlinDrm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// List Marlin DRMs of an MP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the mp4. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.MarlinDrm>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }

        internal interface IMarlinApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}/drm/marlin")]
            [AllowAnyStatusCode]
            Task<Models.MarlinDrm> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.MarlinDrm marlinDrm);

            [Delete("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}/drm/marlin/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.MarlinDrm> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}/drm/marlin/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.MarlinDrm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}/drm/marlin")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.MarlinDrm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
