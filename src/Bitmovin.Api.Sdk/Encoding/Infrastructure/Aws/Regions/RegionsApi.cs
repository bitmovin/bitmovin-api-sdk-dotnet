using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Aws.Regions
{
    /// <summary>
    /// API for RegionsApi
    /// </summary>
    public class RegionsApi
    {
        private readonly IRegionsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the RegionsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public RegionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IRegionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of RegionsApi
        /// </summary>
        public static BitmovinApiBuilder<RegionsApi> Builder => new BitmovinApiBuilder<RegionsApi>();

        /// <summary>
        /// Add AWS Region Setting
        /// </summary>
        /// <param name="infrastructureId">Id of the AWS account (required)</param>
        /// <param name="region">AWS region. (required)</param>
        /// <param name="awsAccountRegionSettings">The AWS Region Settings to be added</param>
        public async Task<Models.AwsAccountRegionSettings> CreateAsync(string infrastructureId, Models.AwsCloudRegion region, Models.AwsAccountRegionSettings awsAccountRegionSettings)
        {
            return await _apiClient.CreateAsync(infrastructureId, region, awsAccountRegionSettings);
        }

        /// <summary>
        /// Delete AWS Region Settings
        /// </summary>
        /// <param name="infrastructureId">Id of the AWS account (required)</param>
        /// <param name="region">AWS region. (required)</param>
        public async Task<Models.AwsAccountRegionSettings> DeleteAsync(string infrastructureId, Models.AwsCloudRegion region)
        {
            return await _apiClient.DeleteAsync(infrastructureId, region);
        }

        /// <summary>
        /// AWS Region Settings Details
        /// </summary>
        /// <param name="infrastructureId">Id of the AWS account (required)</param>
        /// <param name="region">AWS region. (required)</param>
        public async Task<Models.AwsAccountRegionSettings> GetAsync(string infrastructureId, Models.AwsCloudRegion region)
        {
            return await _apiClient.GetAsync(infrastructureId, region);
        }

        /// <summary>
        /// List AWS Region Settings
        /// </summary>
        /// <param name="infrastructureId">Id of the AWS account (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AwsAccountRegionSettings>> ListAsync(string infrastructureId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(infrastructureId, q);
        }

        internal interface IRegionsApiClient
        {
            [Post("/encoding/infrastructure/aws/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.AwsAccountRegionSettings> CreateAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.AwsCloudRegion region, [Body] Models.AwsAccountRegionSettings awsAccountRegionSettings);

            [Delete("/encoding/infrastructure/aws/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.AwsAccountRegionSettings> DeleteAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.AwsCloudRegion region);

            [Get("/encoding/infrastructure/aws/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.AwsAccountRegionSettings> GetAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.AwsCloudRegion region);

            [Get("/encoding/infrastructure/aws/{infrastructure_id}/regions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AwsAccountRegionSettings>> ListAsync([Path("infrastructure_id")] string infrastructureId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
