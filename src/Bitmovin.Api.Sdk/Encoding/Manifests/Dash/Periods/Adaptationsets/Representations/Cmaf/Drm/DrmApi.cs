using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Cmaf.Drm.Contentprotection;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Cmaf.Drm
{
    public class DrmApi
    {
        private readonly IDrmApiClient _apiClient;

        public DrmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDrmApiClient>();

            Contentprotection = new ContentprotectionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DrmApi
        /// </summary>
        public static BitmovinApiBuilder<DrmApi> Builder => new BitmovinApiBuilder<DrmApi>();

        public ContentprotectionApi Contentprotection { get; private set; }
        
        /// <summary>
        /// Add DRM CMAF Representation
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="adaptationsetId">Id of the adaptation set</param>
        /// <param name="dashCmafDrmRepresentation">The request payload</param>
        public async Task<Models.DashCmafDrmRepresentation> CreateAsync(string manifestId, string periodId, string adaptationsetId, Models.DashCmafDrmRepresentation dashCmafDrmRepresentation)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, adaptationsetId, dashCmafDrmRepresentation);
        }
        
        /// <summary>
        /// Delete DRM CMAF Representation
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="adaptationsetId">Id of the adaptation set</param>
        /// <param name="representationId">Id of the DRM CMAF representation to be deleted</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string adaptationsetId, string representationId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, adaptationsetId, representationId);
        }
        
        /// <summary>
        /// DRM CMAF Representation Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="adaptationsetId">Id of the adaptation set</param>
        /// <param name="representationId">Id of the representation</param>
        public async Task<Models.DashCmafDrmRepresentation> GetAsync(string manifestId, string periodId, string adaptationsetId, string representationId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId, representationId);
        }
        
        /// <summary>
        /// List all DRM CMAF Representations
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="adaptationsetId">Id of the adaptation set</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DashCmafDrmRepresentation>> ListAsync(string manifestId, string periodId, string adaptationsetId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, adaptationsetId, q);
        }
        
        internal interface IDrmApiClient
        {
            
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/cmaf/drm")]
            [AllowAnyStatusCode]
            Task<Models.DashCmafDrmRepresentation> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Body] Models.DashCmafDrmRepresentation dashCmafDrmRepresentation);
            
            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/cmaf/drm/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId);
            
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/cmaf/drm/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.DashCmafDrmRepresentation> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId);
            
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/cmaf/drm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DashCmafDrmRepresentation>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

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
