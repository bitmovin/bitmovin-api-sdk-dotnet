using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Default;
using Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Customdata;
using Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Representations;
using Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Contentprotection;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Smooth
{
    public class SmoothApi
    {
        private readonly ISmoothApiClient _apiClient;

        public SmoothApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISmoothApiClient>();
            Default = new DefaultApi(apiClientFactory);
            Customdata = new CustomdataApi(apiClientFactory);
            Representations = new RepresentationsApi(apiClientFactory);
            Contentprotection = new ContentprotectionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SmoothApi
        /// </summary>
        public static BitmovinApiBuilder<SmoothApi> Builder => new BitmovinApiBuilder<SmoothApi>();

        public DefaultApi Default { get; }
        public CustomdataApi Customdata { get; }
        public RepresentationsApi Representations { get; }
        public ContentprotectionApi Contentprotection { get; }

        /// <summary>
        /// Create Smooth Streaming Manifest
        /// </summary>
        /// <param name="smoothStreamingManifest">The Custom Smooth Streaming Manifest to be created.</param>
        public async Task<Models.SmoothStreamingManifest> CreateAsync(Models.SmoothStreamingManifest smoothStreamingManifest)
        {
            return await _apiClient.CreateAsync(smoothStreamingManifest);
        }

        /// <summary>
        /// Delete Smooth Streaming Manifest
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming Manifest. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId)
        {
            return await _apiClient.DeleteAsync(manifestId);
        }

        /// <summary>
        /// Smooth Streaming Manifest Details
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming Manifest. (required)</param>
        public async Task<Models.SmoothStreamingManifest> GetAsync(string manifestId)
        {
            return await _apiClient.GetAsync(manifestId);
        }

        /// <summary>
        /// Manifest Start Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        public async Task<Models.StartManifestRequest> GetStartRequestAsync(string manifestId)
        {
            return await _apiClient.GetStartRequestAsync(manifestId);
        }

        /// <summary>
        /// List Smooth Streaming Manifests
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SmoothStreamingManifest>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Start Smooth Streaming manifest generation
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming Manifest. (required)</param>
        /// <param name="startManifestRequest">Manifest Startup Options</param>
        public async Task<Models.BitmovinResponse> StartAsync(string manifestId, Models.StartManifestRequest startManifestRequest = null)
        {
            return await _apiClient.StartAsync(manifestId, startManifestRequest);
        }

        /// <summary>
        /// Smooth Streaming manifest generation status
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming Manifest. (required)</param>
        public async Task<Models.ServiceTaskStatus> StatusAsync(string manifestId)
        {
            return await _apiClient.StatusAsync(manifestId);
        }

        /// <summary>
        /// Stop Smooth Streaming manifest generation
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming Manifest. (required)</param>
        public async Task<Models.BitmovinResponse> StopAsync(string manifestId)
        {
            return await _apiClient.StopAsync(manifestId);
        }

        internal interface ISmoothApiClient
        {
            [Post("/encoding/manifests/smooth")]
            [AllowAnyStatusCode]
            Task<Models.SmoothStreamingManifest> CreateAsync([Body] Models.SmoothStreamingManifest smoothStreamingManifest);

            [Delete("/encoding/manifests/smooth/{manifest_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId);

            [Get("/encoding/manifests/smooth/{manifest_id}")]
            [AllowAnyStatusCode]
            Task<Models.SmoothStreamingManifest> GetAsync([Path("manifest_id")] string manifestId);

            [Get("/encoding/manifests/smooth/{manifest_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.StartManifestRequest> GetStartRequestAsync([Path("manifest_id")] string manifestId);

            [Get("/encoding/manifests/smooth")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SmoothStreamingManifest>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Post("/encoding/manifests/smooth/{manifest_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("manifest_id")] string manifestId, [Body] Models.StartManifestRequest startManifestRequest);

            [Get("/encoding/manifests/smooth/{manifest_id}/status")]
            [AllowAnyStatusCode]
            Task<Models.ServiceTaskStatus> StatusAsync([Path("manifest_id")] string manifestId);

            [Post("/encoding/manifests/smooth/{manifest_id}/stop")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StopAsync([Path("manifest_id")] string manifestId);
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
