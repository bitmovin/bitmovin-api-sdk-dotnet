using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Aws.Regions;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Aws
{
    public class AwsApi
    {
        private readonly IAwsApiClient _apiClient;

        public AwsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAwsApiClient>();
            Regions = new RegionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AwsApi
        /// </summary>
        public static BitmovinApiBuilder<AwsApi> Builder => new BitmovinApiBuilder<AwsApi>();

        public RegionsApi Regions { get; }

        /// <summary>
        /// Add AWS Account
        /// </summary>
        /// <param name="awsAccount">The AWS Account to be added</param>
        public async Task<Models.AwsAccount> CreateAsync(Models.AwsAccount awsAccount)
        {
            return await _apiClient.CreateAsync(awsAccount);
        }

        /// <summary>
        /// Delete AWS Account
        /// </summary>
        /// <param name="infrastructureId">Id of the AWS account (required)</param>
        public async Task<Models.AwsAccount> DeleteAsync(string infrastructureId)
        {
            return await _apiClient.DeleteAsync(infrastructureId);
        }

        /// <summary>
        /// AWS Account Details
        /// </summary>
        /// <param name="infrastructureId">Id of the AWS account (required)</param>
        public async Task<Models.AwsAccount> GetAsync(string infrastructureId)
        {
            return await _apiClient.GetAsync(infrastructureId);
        }

        /// <summary>
        /// List AWS Accounts
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AwsAccount>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAwsApiClient
        {
            [Post("/encoding/infrastructure/aws")]
            [AllowAnyStatusCode]
            Task<Models.AwsAccount> CreateAsync([Body] Models.AwsAccount awsAccount);

            [Delete("/encoding/infrastructure/aws/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.AwsAccount> DeleteAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/aws/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.AwsAccount> GetAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/aws")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AwsAccount>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
