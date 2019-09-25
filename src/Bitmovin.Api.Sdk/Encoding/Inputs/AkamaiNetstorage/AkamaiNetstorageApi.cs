using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.AkamaiNetstorage.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.AkamaiNetstorage
{
    public class AkamaiNetstorageApi
    {
        private readonly IAkamaiNetstorageApiClient _apiClient;

        public AkamaiNetstorageApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAkamaiNetstorageApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AkamaiNetstorageApi
        /// </summary>
        public static BitmovinApiBuilder<AkamaiNetstorageApi> Builder => new BitmovinApiBuilder<AkamaiNetstorageApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Akamai NetStorage Input
        /// </summary>
        /// <param name="akamaiNetStorageInput">The request payload</param>
        public async Task<Models.AkamaiNetStorageInput> CreateAsync(Models.AkamaiNetStorageInput akamaiNetStorageInput)
        {
            return await _apiClient.CreateAsync(akamaiNetStorageInput);
        }
        
        /// <summary>
        /// Delete Akamai NetStorage Input
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.AkamaiNetStorageInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }
        
        /// <summary>
        /// Akamai NetStorage Input Details
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.AkamaiNetStorageInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }
        
        /// <summary>
        /// List Akamai NetStorage Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AkamaiNetStorageInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IAkamaiNetstorageApiClient
        {
            
            [Post("/encoding/inputs/akamai-netstorage")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiNetStorageInput> CreateAsync([Body] Models.AkamaiNetStorageInput akamaiNetStorageInput);
            
            [Delete("/encoding/inputs/akamai-netstorage/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiNetStorageInput> DeleteAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/akamai-netstorage/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiNetStorageInput> GetAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/akamai-netstorage")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AkamaiNetStorageInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
