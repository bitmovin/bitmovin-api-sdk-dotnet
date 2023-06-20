using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Default;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Customdata;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash
{
    public class DashApi
    {
        private readonly IDashApiClient _apiClient;

        public DashApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDashApiClient>();
            Default = new DefaultApi(apiClientFactory);
            Customdata = new CustomdataApi(apiClientFactory);
            Periods = new PeriodsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DashApi
        /// </summary>
        public static BitmovinApiBuilder<DashApi> Builder => new BitmovinApiBuilder<DashApi>();

        public DefaultApi Default { get; }
        public CustomdataApi Customdata { get; }
        public PeriodsApi Periods { get; }

        /// <summary>
        /// Create Custom DASH Manifest
        /// </summary>
        /// <param name="dashManifest">A Custom DASH Manifest gives you full control over its contents. Add Periods, Adaptation Sets, Representations, Content Protections or Custom XML Elements via the respective endpoints. If you need a simpler solution, create a Default Manifest resource instead. See [documentation](https://developer.bitmovin.com/encoding/docs/default-vs-custom-manifest) page for a comparison</param>
        public async Task<Models.DashManifest> CreateAsync(Models.DashManifest dashManifest)
        {
            return await _apiClient.CreateAsync(dashManifest);
        }

        /// <summary>
        /// Delete DASH Manifest
        /// </summary>
        /// <param name="manifestId">UUID of the DASH Manifest to be deleted (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId)
        {
            return await _apiClient.DeleteAsync(manifestId);
        }

        /// <summary>
        /// DASH Manifest Details
        /// </summary>
        /// <param name="manifestId">UUID of the DASH Manifest (required)</param>
        public async Task<Models.DashManifest> GetAsync(string manifestId)
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
        /// List DASH Manifests
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DashManifest>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Start DASH manifest generation
        /// </summary>
        /// <param name="manifestId">Id of the DASH Manifest. (required)</param>
        /// <param name="startManifestRequest">Manifest Startup Options</param>
        public async Task<Models.BitmovinResponse> StartAsync(string manifestId, Models.StartManifestRequest startManifestRequest = null)
        {
            return await _apiClient.StartAsync(manifestId, startManifestRequest);
        }

        /// <summary>
        /// DASH manifest generation status
        /// </summary>
        /// <param name="manifestId">Id of the DASH Manifest. (required)</param>
        public async Task<Models.ServiceTaskStatus> StatusAsync(string manifestId)
        {
            return await _apiClient.StatusAsync(manifestId);
        }

        /// <summary>
        /// Stop DASH manifest generation
        /// </summary>
        /// <param name="manifestId">Id of the DASH Manifest. (required)</param>
        public async Task<Models.BitmovinResponse> StopAsync(string manifestId)
        {
            return await _apiClient.StopAsync(manifestId);
        }

        internal interface IDashApiClient
        {
            [Post("/encoding/manifests/dash")]
            [AllowAnyStatusCode]
            Task<Models.DashManifest> CreateAsync([Body] Models.DashManifest dashManifest);

            [Delete("/encoding/manifests/dash/{manifest_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId);

            [Get("/encoding/manifests/dash/{manifest_id}")]
            [AllowAnyStatusCode]
            Task<Models.DashManifest> GetAsync([Path("manifest_id")] string manifestId);

            [Get("/encoding/manifests/dash/{manifest_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.StartManifestRequest> GetStartRequestAsync([Path("manifest_id")] string manifestId);

            [Get("/encoding/manifests/dash")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DashManifest>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Post("/encoding/manifests/dash/{manifest_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("manifest_id")] string manifestId, [Body] Models.StartManifestRequest startManifestRequest);

            [Get("/encoding/manifests/dash/{manifest_id}/status")]
            [AllowAnyStatusCode]
            Task<Models.ServiceTaskStatus> StatusAsync([Path("manifest_id")] string manifestId);

            [Post("/encoding/manifests/dash/{manifest_id}/stop")]
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
