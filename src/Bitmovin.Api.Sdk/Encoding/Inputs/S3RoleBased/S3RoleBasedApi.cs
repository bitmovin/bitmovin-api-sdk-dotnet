using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.S3RoleBased.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.S3RoleBased
{
    public class S3RoleBasedApi
    {
        private readonly IS3RoleBasedApiClient _apiClient;

        public S3RoleBasedApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IS3RoleBasedApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of S3RoleBasedApi
        /// </summary>
        public static BitmovinApiBuilder<S3RoleBasedApi> Builder => new BitmovinApiBuilder<S3RoleBasedApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create S3 Role-based Input
        /// </summary>
        /// <param name="s3RoleBasedInput">The request payload</param>
        public async Task<Models.S3RoleBasedInput> CreateAsync(Models.S3RoleBasedInput s3RoleBasedInput)
        {
            return await _apiClient.CreateAsync(s3RoleBasedInput);
        }
        
        /// <summary>
        /// Delete S3 Role-based Input
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.S3RoleBasedInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }
        
        /// <summary>
        /// S3 Role-based Input Details
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.S3RoleBasedInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }
        
        /// <summary>
        /// List S3 Role-based Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.S3RoleBasedInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IS3RoleBasedApiClient
        {
            
            [Post("/encoding/inputs/s3-role-based")]
            [AllowAnyStatusCode]
            Task<Models.S3RoleBasedInput> CreateAsync([Body] Models.S3RoleBasedInput s3RoleBasedInput);
            
            [Delete("/encoding/inputs/s3-role-based/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.S3RoleBasedInput> DeleteAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/s3-role-based/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.S3RoleBasedInput> GetAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/s3-role-based")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.S3RoleBasedInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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

            /// <summary>
            /// Filter inputs by name
            /// </summary>
            public ListQueryParams Name(string Name) => SetQueryParam("name", Name);

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
