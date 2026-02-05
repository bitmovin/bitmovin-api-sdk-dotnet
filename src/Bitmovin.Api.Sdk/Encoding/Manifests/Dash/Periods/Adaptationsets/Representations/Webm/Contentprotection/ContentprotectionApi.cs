using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Webm.Contentprotection
{
    /// <summary>
    /// API for ContentprotectionApi
    /// </summary>
    public class ContentprotectionApi
    {
        private readonly IContentprotectionApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ContentprotectionApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ContentprotectionApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IContentprotectionApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ContentprotectionApi
        /// </summary>
        public static BitmovinApiBuilder<ContentprotectionApi> Builder => new BitmovinApiBuilder<ContentprotectionApi>();

        /// <summary>
        /// Add Content Protection to WebM Representation
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the representation (required)</param>
        /// <param name="contentProtection">The content protection to be added to the WebM representation</param>
        public async Task<Models.ContentProtection> CreateAsync(string manifestId, string periodId, string adaptationsetId, string representationId, Models.ContentProtection contentProtection)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, adaptationsetId, representationId, contentProtection);
        }

        /// <summary>
        /// Delete WebM Representation Content Protection
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the representation (required)</param>
        /// <param name="contentprotectionId">Id of the DRM WebM content protection to be deleted (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string adaptationsetId, string representationId, string contentprotectionId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, adaptationsetId, representationId, contentprotectionId);
        }

        /// <summary>
        /// WebM Representation Content Protection Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the representation (required)</param>
        /// <param name="contentprotectionId">Id of the DRM WebM content protection (required)</param>
        public async Task<Models.ContentProtection> GetAsync(string manifestId, string periodId, string adaptationsetId, string representationId, string contentprotectionId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId, representationId, contentprotectionId);
        }

        /// <summary>
        /// List all WebM Representation Content Protections
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the representation (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ContentProtection>> ListAsync(string manifestId, string periodId, string adaptationsetId, string representationId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, adaptationsetId, representationId, q);
        }

        internal interface IContentprotectionApiClient
        {
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/webm/{representation_id}/contentprotection")]
            [AllowAnyStatusCode]
            Task<Models.ContentProtection> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId, [Body] Models.ContentProtection contentProtection);

            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/webm/{representation_id}/contentprotection/{contentprotection_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId, [Path("contentprotection_id")] string contentprotectionId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/webm/{representation_id}/contentprotection/{contentprotection_id}")]
            [AllowAnyStatusCode]
            Task<Models.ContentProtection> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId, [Path("contentprotection_id")] string contentprotectionId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/webm/{representation_id}/contentprotection")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ContentProtection>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
