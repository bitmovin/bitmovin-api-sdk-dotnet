using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.ProgressiveWebm
{
    /// <summary>
    /// API for ProgressiveWebmApi
    /// </summary>
    public class ProgressiveWebmApi
    {
        private readonly IProgressiveWebmApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ProgressiveWebmApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ProgressiveWebmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IProgressiveWebmApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ProgressiveWebmApi
        /// </summary>
        public static BitmovinApiBuilder<ProgressiveWebmApi> Builder => new BitmovinApiBuilder<ProgressiveWebmApi>();

        /// <summary>
        /// Add Progressive WebM Representation
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="dashProgressiveWebmRepresentation">The Progressive WebM representation to be added to the adaptation set</param>
        public async Task<Models.DashProgressiveWebmRepresentation> CreateAsync(string manifestId, string periodId, string adaptationsetId, Models.DashProgressiveWebmRepresentation dashProgressiveWebmRepresentation)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, adaptationsetId, dashProgressiveWebmRepresentation);
        }

        /// <summary>
        /// Delete Progressive WebM Representation
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the Progressive WebM representation to be deleted (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string adaptationsetId, string representationId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, adaptationsetId, representationId);
        }

        /// <summary>
        /// Progressive WebM Representation Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the representation (required)</param>
        public async Task<Models.DashProgressiveWebmRepresentation> GetAsync(string manifestId, string periodId, string adaptationsetId, string representationId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId, representationId);
        }

        /// <summary>
        /// List all Progressive WebM Representations
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DashProgressiveWebmRepresentation>> ListAsync(string manifestId, string periodId, string adaptationsetId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, adaptationsetId, q);
        }

        internal interface IProgressiveWebmApiClient
        {
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/progressive-webm")]
            [AllowAnyStatusCode]
            Task<Models.DashProgressiveWebmRepresentation> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Body] Models.DashProgressiveWebmRepresentation dashProgressiveWebmRepresentation);

            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/progressive-webm/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/progressive-webm/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.DashProgressiveWebmRepresentation> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/progressive-webm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DashProgressiveWebmRepresentation>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
