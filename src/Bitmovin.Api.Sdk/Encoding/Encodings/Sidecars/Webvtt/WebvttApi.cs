using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars.Webvtt
{
    /// <summary>
    /// API for WebvttApi
    /// </summary>
    public class WebvttApi
    {
        private readonly IWebvttApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the WebvttApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public WebvttApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWebvttApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of WebvttApi
        /// </summary>
        public static BitmovinApiBuilder<WebvttApi> Builder => new BitmovinApiBuilder<WebvttApi>();

        /// <summary>
        /// Add WebVTT sidecar file
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="webVttSidecarFile">The WebVTT Sidecar file to be added</param>
        public async Task<Models.WebVttSidecarFile> CreateAsync(string encodingId, Models.WebVttSidecarFile webVttSidecarFile)
        {
            return await _apiClient.CreateAsync(encodingId, webVttSidecarFile);
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
        /// WebVTT Sidecar Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="sidecarId">Id of the sidecar. (required)</param>
        public async Task<Models.WebVttSidecarFile> GetAsync(string encodingId, string sidecarId)
        {
            return await _apiClient.GetAsync(encodingId, sidecarId);
        }

        /// <summary>
        /// List WebVTT sidecar files
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.WebVttSidecarFile>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IWebvttApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/sidecars/webvtt")]
            [AllowAnyStatusCode]
            Task<Models.WebVttSidecarFile> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.WebVttSidecarFile webVttSidecarFile);

            [Delete("/encoding/encodings/{encoding_id}/sidecars/webvtt/{sidecar_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("sidecar_id")] string sidecarId);

            [Get("/encoding/encodings/{encoding_id}/sidecars/webvtt/{sidecar_id}")]
            [AllowAnyStatusCode]
            Task<Models.WebVttSidecarFile> GetAsync([Path("encoding_id")] string encodingId, [Path("sidecar_id")] string sidecarId);

            [Get("/encoding/encodings/{encoding_id}/sidecars/webvtt")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.WebVttSidecarFile>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
