using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Default;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Customdata;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Streams;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls
{
    /// <summary>
    /// API for HlsApi
    /// </summary>
    public class HlsApi
    {
        private readonly IHlsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the HlsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public HlsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IHlsApiClient>();
            Default = new DefaultApi(apiClientFactory);
            Customdata = new CustomdataApi(apiClientFactory);
            Streams = new StreamsApi(apiClientFactory);
            Media = new MediaApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of HlsApi
        /// </summary>
        public static BitmovinApiBuilder<HlsApi> Builder => new BitmovinApiBuilder<HlsApi>();

        /// <summary>
        /// Gets the Default API
        /// </summary>
        public DefaultApi Default { get; }
        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }
        /// <summary>
        /// Gets the Streams API
        /// </summary>
        public StreamsApi Streams { get; }
        /// <summary>
        /// Gets the Media API
        /// </summary>
        public MediaApi Media { get; }

        /// <summary>
        /// Create Custom HLS Manifest
        /// </summary>
        /// <param name="hlsManifest">The Custom HLS Manifest to be created.</param>
        public async Task<Models.HlsManifest> CreateAsync(Models.HlsManifest hlsManifest)
        {
            return await _apiClient.CreateAsync(hlsManifest);
        }

        /// <summary>
        /// Delete HLS Manifest
        /// </summary>
        /// <param name="manifestId">Id of the HLS Manifest. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId)
        {
            return await _apiClient.DeleteAsync(manifestId);
        }

        /// <summary>
        /// HLS Manifest Details
        /// </summary>
        /// <param name="manifestId">Id of the HLS Manifest. (required)</param>
        public async Task<Models.HlsManifest> GetAsync(string manifestId)
        {
            return await _apiClient.GetAsync(manifestId);
        }

        /// <summary>
        /// Manifest Start Details
        /// </summary>
        /// <param name="manifestId">ID of the manifest (required)</param>
        public async Task<Models.StartManifestRequest> GetStartRequestAsync(string manifestId)
        {
            return await _apiClient.GetStartRequestAsync(manifestId);
        }

        /// <summary>
        /// List HLS Manifests
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.HlsManifest>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Start HLS manifest generation
        /// </summary>
        /// <param name="manifestId">Id of the HLS Manifest. (required)</param>
        /// <param name="startManifestRequest">Manifest Startup Options</param>
        public async Task<Models.BitmovinResponse> StartAsync(string manifestId, Models.StartManifestRequest startManifestRequest = null)
        {
            return await _apiClient.StartAsync(manifestId, startManifestRequest);
        }

        /// <summary>
        /// HLS manifest generation status
        /// </summary>
        /// <param name="manifestId">Id of the HLS Manifest. (required)</param>
        public async Task<Models.ServiceTaskStatus> StatusAsync(string manifestId)
        {
            return await _apiClient.StatusAsync(manifestId);
        }

        /// <summary>
        /// Stop HLS manifest generation
        /// </summary>
        /// <param name="manifestId">Id of the HLS Manifest. (required)</param>
        public async Task<Models.BitmovinResponse> StopAsync(string manifestId)
        {
            return await _apiClient.StopAsync(manifestId);
        }

        internal interface IHlsApiClient
        {
            [Post("/encoding/manifests/hls")]
            [AllowAnyStatusCode]
            Task<Models.HlsManifest> CreateAsync([Body] Models.HlsManifest hlsManifest);

            [Delete("/encoding/manifests/hls/{manifest_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId);

            [Get("/encoding/manifests/hls/{manifest_id}")]
            [AllowAnyStatusCode]
            Task<Models.HlsManifest> GetAsync([Path("manifest_id")] string manifestId);

            [Get("/encoding/manifests/hls/{manifest_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.StartManifestRequest> GetStartRequestAsync([Path("manifest_id")] string manifestId);

            [Get("/encoding/manifests/hls")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.HlsManifest>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Post("/encoding/manifests/hls/{manifest_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("manifest_id")] string manifestId, [Body] Models.StartManifestRequest startManifestRequest);

            [Get("/encoding/manifests/hls/{manifest_id}/status")]
            [AllowAnyStatusCode]
            Task<Models.ServiceTaskStatus> StatusAsync([Path("manifest_id")] string manifestId);

            [Post("/encoding/manifests/hls/{manifest_id}/stop")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StopAsync([Path("manifest_id")] string manifestId);
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

            /// <summary>
            /// Order list result according to a filter resource attribute. The fields that can be used for sorting are: + &#x60;id&#x60; + &#x60;createdAt&#x60; + &#x60;modifiedAt&#x60; + &#x60;type&#x60; + &#x60;name&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

            /// <summary>
            /// Get the manifests that belong to that encoding id
            /// </summary>
            public ListQueryParams EncodingId(string encodingId) => SetQueryParam("encodingId", encodingId);

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
