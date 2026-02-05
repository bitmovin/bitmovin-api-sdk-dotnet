using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars.Webvtt;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars
{
    /// <summary>
    /// API for SidecarsApi
    /// </summary>
    public class SidecarsApi
    {
        private readonly ISidecarsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the SidecarsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SidecarsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISidecarsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
            Webvtt = new WebvttApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SidecarsApi
        /// </summary>
        public static BitmovinApiBuilder<SidecarsApi> Builder => new BitmovinApiBuilder<SidecarsApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }
        /// <summary>
        /// Gets the Webvtt API
        /// </summary>
        public WebvttApi Webvtt { get; }

        /// <summary>
        /// Add Sidecar
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="sidecarFile">The Sidecar to be added</param>
        public async Task<Models.SidecarFile> CreateAsync(string encodingId, Models.SidecarFile sidecarFile)
        {
            return await _apiClient.CreateAsync(encodingId, sidecarFile);
        }

        /// <summary>
        /// Delete Sidecar
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="sidecarId">Id of the sidecar. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string sidecarId)
        {
            return await _apiClient.DeleteAsync(encodingId, sidecarId);
        }

        /// <summary>
        /// Sidecar Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="sidecarId">Id of the sidecar. (required)</param>
        public async Task<Models.SidecarFile> GetAsync(string encodingId, string sidecarId)
        {
            return await _apiClient.GetAsync(encodingId, sidecarId);
        }

        /// <summary>
        /// List Sidecars
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SidecarFile>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface ISidecarsApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/sidecars")]
            [AllowAnyStatusCode]
            Task<Models.SidecarFile> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.SidecarFile sidecarFile);

            [Delete("/encoding/encodings/{encoding_id}/sidecars/{sidecar_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("sidecar_id")] string sidecarId);

            [Get("/encoding/encodings/{encoding_id}/sidecars/{sidecar_id}")]
            [AllowAnyStatusCode]
            Task<Models.SidecarFile> GetAsync([Path("encoding_id")] string encodingId, [Path("sidecar_id")] string sidecarId);

            [Get("/encoding/encodings/{encoding_id}/sidecars")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SidecarFile>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
