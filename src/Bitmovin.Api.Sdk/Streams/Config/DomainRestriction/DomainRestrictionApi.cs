using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams.Config.DomainRestriction
{
    /// <summary>
    /// API for DomainRestrictionApi
    /// </summary>
    public class DomainRestrictionApi
    {
        private readonly IDomainRestrictionApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DomainRestrictionApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DomainRestrictionApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDomainRestrictionApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DomainRestrictionApi
        /// </summary>
        public static BitmovinApiBuilder<DomainRestrictionApi> Builder => new BitmovinApiBuilder<DomainRestrictionApi>();

        /// <summary>
        /// Create new streams domain restriction
        /// </summary>
        /// <param name="streamsDomainRestrictionCreateRequest">Create a new streams domain restriction</param>
        public async Task<Models.StreamsDomainRestrictionResponse> CreateAsync(Models.StreamsDomainRestrictionCreateRequest streamsDomainRestrictionCreateRequest)
        {
            return await _apiClient.CreateAsync(streamsDomainRestrictionCreateRequest);
        }

        /// <summary>
        /// Delete streams domain restriction by id
        /// </summary>
        /// <param name="domainRestrictionId">Id of the streams domain restriction. (required)</param>
        public async Task DeleteAsync(string domainRestrictionId)
        {
            await _apiClient.DeleteAsync(domainRestrictionId);
        }

        /// <summary>
        /// Get streams domain restriction config by id
        /// </summary>
        /// <param name="domainRestrictionId">Id of the streams domain restriction. (required)</param>
        public async Task<Models.StreamsDomainRestrictionResponse> GetAsync(string domainRestrictionId)
        {
            return await _apiClient.GetAsync(domainRestrictionId);
        }

        /// <summary>
        /// Get paginated list of domain restriction configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StreamsDomainRestrictionResponse>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Partially update streams domain restriction by id
        /// </summary>
        /// <param name="domainRestrictionId">Id of the streams domain restriction. (required)</param>
        /// <param name="streamsDomainRestrictionUpdateRequest">The updated streams domain restriction object.</param>
        public async Task<Models.StreamsDomainRestrictionResponse> PatchStreamsDomainRestrictionAsync(string domainRestrictionId, Models.StreamsDomainRestrictionUpdateRequest streamsDomainRestrictionUpdateRequest)
        {
            return await _apiClient.PatchStreamsDomainRestrictionAsync(domainRestrictionId, streamsDomainRestrictionUpdateRequest);
        }

        internal interface IDomainRestrictionApiClient
        {
            [Post("/streams/config/domain-restriction")]
            [AllowAnyStatusCode]
            Task<Models.StreamsDomainRestrictionResponse> CreateAsync([Body] Models.StreamsDomainRestrictionCreateRequest streamsDomainRestrictionCreateRequest);

            [Delete("/streams/config/domain-restriction/{domain_restriction_id}")]
            [AllowAnyStatusCode]
            Task DeleteAsync([Path("domain_restriction_id")] string domainRestrictionId);

            [Get("/streams/config/domain-restriction/{domain_restriction_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamsDomainRestrictionResponse> GetAsync([Path("domain_restriction_id")] string domainRestrictionId);

            [Get("/streams/config/domain-restriction")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StreamsDomainRestrictionResponse>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Patch("/streams/config/domain-restriction/{domain_restriction_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamsDomainRestrictionResponse> PatchStreamsDomainRestrictionAsync([Path("domain_restriction_id")] string domainRestrictionId, [Body] Models.StreamsDomainRestrictionUpdateRequest streamsDomainRestrictionUpdateRequest);
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
