using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Type
{
    public class TypeApi
    {
        private readonly ITypeApiClient _apiClient;

        public TypeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITypeApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TypeApi
        /// </summary>
        public static BitmovinApiBuilder<TypeApi> Builder => new BitmovinApiBuilder<TypeApi>();

        /// <summary>
        /// Get DASH representation type
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="representationId">Id of the representation (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.DashRepresentationTypeResponse> GetAsync(string manifestId, string periodId, string adaptationsetId, string representationId, params Func<GetQueryParams, GetQueryParams>[] queryParams)
        {
            GetQueryParams q = new GetQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId, representationId, q);
        }

        internal interface ITypeApiClient
        {
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations/{representation_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.DashRepresentationTypeResponse> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [Path("representation_id")] string representationId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        public class GetQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public GetQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public GetQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private GetQueryParams SetQueryParam<T>(string key, T value)
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
