using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Type
{
    /// <summary>
    /// API for TypeApi
    /// </summary>
    public class TypeApi
    {
        private readonly ITypeApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the TypeApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public TypeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITypeApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TypeApi
        /// </summary>
        public static BitmovinApiBuilder<TypeApi> Builder => new BitmovinApiBuilder<TypeApi>();

        /// <summary>
        /// Get adaptation set type
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        public async Task<Models.AdaptationSetTypeResponse> GetAsync(string manifestId, string periodId, string adaptationsetId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId);
        }

        internal interface ITypeApiClient
        {
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.AdaptationSetTypeResponse> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId);
        }
    }
}
