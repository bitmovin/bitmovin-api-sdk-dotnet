using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Imsc
{
    /// <summary>
    /// API for ImscApi
    /// </summary>
    public class ImscApi
    {
        private readonly IImscApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ImscApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ImscApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IImscApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ImscApi
        /// </summary>
        public static BitmovinApiBuilder<ImscApi> Builder => new BitmovinApiBuilder<ImscApi>();

        /// <summary>
        /// Add IMSC Representation
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the subtitle adaptation set (required)</param>
        /// <param name="dashImscRepresentation">The IMSC representation to be added to the adaptation set. Note that the adaptation set has to be a subtitle adaptation set. </param>
        public async Task<Models.DashImscRepresentation> CreateAsync(string manifestId, string periodId, string adaptationsetId, Models.DashImscRepresentation dashImscRepresentation)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, adaptationsetId, dashImscRepresentation);
        }

        /// <summary>
        /// Delete IMSC Representation
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the IMSC representation to be deleted (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string adaptationsetId, string representationId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, adaptationsetId, representationId);
        }

        /// <summary>
        /// IMSC Representation Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the IMSC representation (required)</param>
        public async Task<Models.DashImscRepresentation> GetAsync(string manifestId, string periodId, string adaptationsetId, string representationId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId, representationId);
        }

        /// <summary>
        /// List all IMSC Representations
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DashImscRepresentation>> ListAsync(string manifestId, string periodId, string adaptationsetId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, adaptationsetId, q);
        }

        internal interface IImscApiClient
        {
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/imsc")]
            [AllowAnyStatusCode]
            Task<Models.DashImscRepresentation> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Body] Models.DashImscRepresentation dashImscRepresentation);

            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/imsc/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/imsc/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.DashImscRepresentation> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/imsc")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DashImscRepresentation>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
