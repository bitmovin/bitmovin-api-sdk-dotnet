using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Webm.Drm.Cenc.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Webm.Drm.Cenc
{
    public class CencApi
    {
        private readonly ICencApiClient _apiClient;

        public CencApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICencApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CencApi
        /// </summary>
        public static BitmovinApiBuilder<CencApi> Builder => new BitmovinApiBuilder<CencApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add CENC DRM to a WebM muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the WebM muxing. (required)</param>
        /// <param name="cencDrm">The CencDrm to be created</param>
        public async Task<Models.CencDrm> CreateAsync(string encodingId, string muxingId, Models.CencDrm cencDrm)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, cencDrm);
        }

        /// <summary>
        /// Delete CENC DRM from a WebM muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the WebM muxing (required)</param>
        /// <param name="drmId">Id of the cenc drm. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// CENC DRM Details of a WebM muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the WebM muxing. (required)</param>
        /// <param name="drmId">Id of the cenc drm. (required)</param>
        public async Task<Models.CencDrm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// List CENC DRMs of a WebM muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the WebM muxing. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CencDrm>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }

        internal interface ICencApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/webm/{muxing_id}/drm/cenc")]
            [AllowAnyStatusCode]
            Task<Models.CencDrm> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.CencDrm cencDrm);

            [Delete("/encoding/encodings/{encoding_id}/muxings/webm/{muxing_id}/drm/cenc/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/webm/{muxing_id}/drm/cenc/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.CencDrm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/webm/{muxing_id}/drm/cenc")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CencDrm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
