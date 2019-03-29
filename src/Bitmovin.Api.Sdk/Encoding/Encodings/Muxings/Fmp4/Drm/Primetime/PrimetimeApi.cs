using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Primetime.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Primetime
{
    public class PrimetimeApi
    {
        private readonly IPrimetimeApiClient _apiClient;

        public PrimetimeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPrimetimeApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of PrimetimeApi
        /// </summary>
        public static BitmovinApiBuilder<PrimetimeApi> Builder => new BitmovinApiBuilder<PrimetimeApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Add PrimeTime DRM to fMP4
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fMP4 muxing.</param>
        /// <param name="primeTimeDrm">The request payload</param>
        public async Task<Models.PrimeTimeDrm> CreateAsync(string encodingId, string muxingId, Models.PrimeTimeDrm primeTimeDrm)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, primeTimeDrm);
        }
        
        /// <summary>
        /// Delete PrimeTime DRM from fMP4
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fmp4 fragment.</param>
        /// <param name="drmId">Id of the PrimeTime DRM configuration.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, drmId);
        }
        
        /// <summary>
        /// PrimeTime DRM Details of fMP4
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fmp4 fragment.</param>
        /// <param name="drmId">Id of the PrimeTime DRM configuration.</param>
        public async Task<Models.PrimeTimeDrm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }
        
        /// <summary>
        /// List PrimeTime DRMs of fMP4
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fmp4 fragment.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.PrimeTimeDrm>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }
        
        internal interface IPrimetimeApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm/primetime")]
            [AllowAnyStatusCode]
            Task<Models.PrimeTimeDrm> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.PrimeTimeDrm primeTimeDrm);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm/primetime/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm/primetime/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.PrimeTimeDrm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm/primetime")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PrimeTimeDrm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// TODO Add description
            /// </summary>
            public ListQueryParams Offset(string Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// TODO Add description
            /// </summary>
            public ListQueryParams Limit(string Limit) => SetQueryParam("limit", Limit);

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
