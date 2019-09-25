using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.AkamaiNetstorage.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.AkamaiNetstorage
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
        /// Create Akamai NetStorage Output
        /// </summary>
        /// <param name="akamaiNetStorageOutput">The request payload</param>
        public async Task<Models.AkamaiNetStorageOutput> CreateAsync(Models.AkamaiNetStorageOutput akamaiNetStorageOutput)
        {
            return await _apiClient.CreateAsync(akamaiNetStorageOutput);
        }
        
        /// <summary>
        /// Delete Akamai NetStorage Output
        /// </summary>
        /// <param name="outputId">Id of the output</param>
        public async Task<Models.AkamaiNetStorageOutput> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }
        
        /// <summary>
        /// Akamai NetStorage Output Details
        /// </summary>
        /// <param name="outputId">Id of the output</param>
        public async Task<Models.AkamaiNetStorageOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }
        
        /// <summary>
        /// List Akamai NetStorage Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AkamaiNetStorageOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            
            [Post("/encoding/outputs/akamai-netstorage")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiNetStorageOutput> CreateAsync([Body] Models.AkamaiNetStorageOutput akamaiNetStorageOutput);
            
            [Delete("/encoding/outputs/akamai-netstorage/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiNetStorageOutput> DeleteAsync([Path("output_id")] string outputId);
            
            [Get("/encoding/outputs/akamai-netstorage/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiNetStorageOutput> GetAsync([Path("output_id")] string outputId);
            
            [Get("/encoding/outputs/akamai-netstorage")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AkamaiNetStorageOutput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
            /// Filter output by name
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
