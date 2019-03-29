using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Drm.Fairplay.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Drm.Fairplay
{
    public class FairplayApi
    {
        private readonly IFairplayApiClient _apiClient;

        public FairplayApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IFairplayApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of FairplayApi
        /// </summary>
        public static BitmovinApiBuilder<FairplayApi> Builder => new BitmovinApiBuilder<FairplayApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Add FairPlay DRM to TS Segment
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the TS muxing.</param>
        /// <param name="fairPlayDrm">The request payload</param>
        public async Task<Models.FairPlayDrm> CreateAsync(string encodingId, string muxingId, Models.FairPlayDrm fairPlayDrm)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, fairPlayDrm);
        }
        
        /// <summary>
        /// Delete FairPlay DRM from TS Segment
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the transport streams segment.</param>
        /// <param name="drmId">Id of the FairPlay DRM configuration.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, drmId);
        }
        
        /// <summary>
        /// FairPlay DRM Details of TS Segment
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the transport streams segment.</param>
        /// <param name="drmId">Id of the FairPlay DRM configuration.</param>
        public async Task<Models.FairPlayDrm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }
        
        /// <summary>
        /// List FairPlay DRMs of TS Segment
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the transport streams segment.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.FairPlayDrm>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }
        
        internal interface IFairplayApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm/fairplay")]
            [AllowAnyStatusCode]
            Task<Models.FairPlayDrm> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.FairPlayDrm fairPlayDrm);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm/fairplay/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm/fairplay/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.FairPlayDrm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm/fairplay")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.FairPlayDrm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
