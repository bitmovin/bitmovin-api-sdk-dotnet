using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Sprite
{
    public class SpriteApi
    {
        private readonly ISpriteApiClient _apiClient;

        public SpriteApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISpriteApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of SpriteApi
        /// </summary>
        public static BitmovinApiBuilder<SpriteApi> Builder => new BitmovinApiBuilder<SpriteApi>();

        /// <summary>
        /// Add Sprite Representation
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the image adaptation set (required)</param>
        /// <param name="spriteRepresentation">The Sprite representation to be added to the adaptation set. Note that the adaptation set has to be an image adaptation set.  Only supported for sprites generated with encoder version &#x60;2.76.0&#x60; or above. </param>
        public async Task<Models.SpriteRepresentation> CreateAsync(string manifestId, string periodId, string adaptationsetId, Models.SpriteRepresentation spriteRepresentation)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, adaptationsetId, spriteRepresentation);
        }

        /// <summary>
        /// Delete Sprite Representation
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the Sprite representation to be deleted (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string adaptationsetId, string representationId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, adaptationsetId, representationId);
        }

        /// <summary>
        /// Sprite Representation Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the Sprite representation (required)</param>
        public async Task<Models.SpriteRepresentation> GetAsync(string manifestId, string periodId, string adaptationsetId, string representationId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId, representationId);
        }

        /// <summary>
        /// List all Sprite Representations
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SpriteRepresentation>> ListAsync(string manifestId, string periodId, string adaptationsetId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, adaptationsetId, q);
        }

        internal interface ISpriteApiClient
        {
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/sprite")]
            [AllowAnyStatusCode]
            Task<Models.SpriteRepresentation> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Body] Models.SpriteRepresentation spriteRepresentation);

            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/sprite/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/sprite/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.SpriteRepresentation> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/sprite")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SpriteRepresentation>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
