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
        /// Create DASH Manifest
        /// </summary>
        /// <param name="dashManifest">The DASH manifest to be created</param>
        public async Task<Models.DashManifest> CreateAsync(Models.DashManifest dashManifest)
        {
            return await _apiClient.CreateAsync(dashManifest);
        }

        /// <summary>
        /// Delete DASH Manifest
        /// </summary>
        /// <param name="manifestId">UUID of the DASH manifest to be deleted (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId)
        {
            return await _apiClient.DeleteAsync(manifestId);
        }

        /// <summary>
        /// DASH Manifest Details
        /// </summary>
        /// <param name="manifestId">UUID of the dash manifest (required)</param>
        public async Task<Models.DashManifest> GetAsync(string manifestId)
        {
            return await _apiClient.GetAsync(manifestId);
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
        /// Start DASH Manifest Creation
        /// </summary>
        /// <param name="manifestId">Id of the DASH manifest. (required)</param>
        /// <param name="body">Manifest Startup Options</param>
        public async Task<Models.BitmovinResponse> StartAsync(string manifestId, Object body = null)
        {
            return await _apiClient.StartAsync(manifestId, body);
        }

        /// <summary>
        /// DASH Manifest Creation Status
        /// </summary>
        /// <param name="manifestId">Id of the DASH manifest. (required)</param>
        public async Task<Models.ServiceTaskStatus> StatusAsync(string manifestId)
        {
            return await _apiClient.StatusAsync(manifestId);
        }

        /// <summary>
        /// Stop DASH Manifest Creation
        /// </summary>
        /// <param name="manifestId">Id of the DASH manifest. (required)</param>
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

            [Get("/encoding/manifests/dash")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DashManifest>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Post("/encoding/manifests/dash/{manifest_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("manifest_id")] string manifestId, [Body] Object body);

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
