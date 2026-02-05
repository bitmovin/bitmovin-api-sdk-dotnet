using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Drm.Aes.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Drm.Aes
{
    /// <summary>
    /// API for AesApi
    /// </summary>
    public class AesApi
    {
        private readonly IAesApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAesApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AesApi
        /// </summary>
        public static BitmovinApiBuilder<AesApi> Builder => new BitmovinApiBuilder<AesApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add AES encryption configuration to a Progressive TS muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="muxingId">Id of the Progressive TS muxing (required)</param>
        /// <param name="aesEncryptionDrm">The AES encryption configuration to be created. Note that for AES encryption in conjunction with Progressive TS muxing the &#39;iv&#39; must remain unset or be empty.</param>
        public async Task<Models.AesEncryptionDrm> CreateAsync(string encodingId, string muxingId, Models.AesEncryptionDrm aesEncryptionDrm)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, aesEncryptionDrm);
        }

        /// <summary>
        /// Delete AES encryption configuration from a Progressive TS muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="muxingId">Id of the Progressive TS muxing (required)</param>
        /// <param name="drmId">Id of the AES encryption configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// AES encryption Details of a Progressive TS muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="muxingId">Id of the Progressive TS muxing (required)</param>
        /// <param name="drmId">Id of the AES encryption configuration (required)</param>
        public async Task<Models.AesEncryptionDrm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// List AES encryption configurations of a Progressive TS muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="muxingId">Id of the Progressive TS muxing (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AesEncryptionDrm>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }

        internal interface IAesApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/drm/aes")]
            [AllowAnyStatusCode]
            Task<Models.AesEncryptionDrm> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.AesEncryptionDrm aesEncryptionDrm);

            [Delete("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/drm/aes/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/drm/aes/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.AesEncryptionDrm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/drm/aes")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AesEncryptionDrm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
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
