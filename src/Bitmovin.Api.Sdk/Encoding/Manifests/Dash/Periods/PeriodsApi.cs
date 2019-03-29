using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.CustomXmlElements;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods
{
    public class PeriodsApi
    {
        private readonly IPeriodsApiClient _apiClient;

        public PeriodsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPeriodsApiClient>();

            CustomXmlElements = new CustomXmlElementsApi(apiClientFactory);
            Adaptationsets = new AdaptationsetsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of PeriodsApi
        /// </summary>
        public static BitmovinApiBuilder<PeriodsApi> Builder => new BitmovinApiBuilder<PeriodsApi>();

        public CustomXmlElementsApi CustomXmlElements { get; private set; }
        public AdaptationsetsApi Adaptationsets { get; private set; }
        
        /// <summary>
        /// Add Period
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="period">The request payload</param>
        public async Task<Models.Period> CreateAsync(string manifestId, Models.Period period)
        {
            return await _apiClient.CreateAsync(manifestId, period);
        }
        
        /// <summary>
        /// Delete Period
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period to be deleted</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId);
        }
        
        /// <summary>
        /// Period Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        public async Task<Models.Period> GetAsync(string manifestId, string periodId)
        {
            return await _apiClient.GetAsync(manifestId, periodId);
        }
        
        /// <summary>
        /// List all Periods
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Period>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }
        
        internal interface IPeriodsApiClient
        {
            
            [Post("/encoding/manifests/dash/{manifest_id}/periods")]
            [AllowAnyStatusCode]
            Task<Models.Period> CreateAsync([Path("manifest_id")] string manifestId, [Body] Models.Period period);
            
            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId);
            
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}")]
            [AllowAnyStatusCode]
            Task<Models.Period> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId);
            
            [Get("/encoding/manifests/dash/{manifest_id}/periods")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Period>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
