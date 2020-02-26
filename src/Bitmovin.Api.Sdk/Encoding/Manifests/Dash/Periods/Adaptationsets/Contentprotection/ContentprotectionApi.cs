using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Contentprotection
{
    public class ContentprotectionApi
    {
        private readonly IContentprotectionApiClient _apiClient;

        public ContentprotectionApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IContentprotectionApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ContentprotectionApi
        /// </summary>
        public static BitmovinApiBuilder<ContentprotectionApi> Builder => new BitmovinApiBuilder<ContentprotectionApi>();

        /// <summary>
        /// Add Content Protection to AdaptationSet
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="contentProtection">The content protection to be added to the adaptation set</param>
        public async Task<Models.ContentProtection> CreateAsync(string manifestId, string periodId, string adaptationsetId, Models.ContentProtection contentProtection)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, adaptationsetId, contentProtection);
        }

        /// <summary>
        /// Delete AdaptationSet Content Protection
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="contentprotectionId">Id of the adaptation set content protection to be deleted (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string adaptationsetId, string contentprotectionId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, adaptationsetId, contentprotectionId);
        }

        /// <summary>
        /// AdaptationSet Content Protection Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="contentprotectionId">Id of the adaptation set content protection (required)</param>
        public async Task<Models.ContentProtection> GetAsync(string manifestId, string periodId, string adaptationsetId, string contentprotectionId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId, contentprotectionId);
        }

        /// <summary>
        /// List all AdaptationSet Content Protections
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ContentProtection>> ListAsync(string manifestId, string periodId, string adaptationsetId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, adaptationsetId, q);
        }

        internal interface IContentprotectionApiClient
        {
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/contentprotection")]
            [AllowAnyStatusCode]
            Task<Models.ContentProtection> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Body] Models.ContentProtection contentProtection);

            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/contentprotection/{contentprotection_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("contentprotection_id")] string contentprotectionId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/contentprotection/{contentprotection_id}")]
            [AllowAnyStatusCode]
            Task<Models.ContentProtection> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("contentprotection_id")] string contentprotectionId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/contentprotection")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ContentProtection>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [QueryMap] IDictionary<String, Object> queryParams);
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
