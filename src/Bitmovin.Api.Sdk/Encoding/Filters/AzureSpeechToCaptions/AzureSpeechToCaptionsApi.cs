using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.AzureSpeechToCaptions.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.AzureSpeechToCaptions
{
    public class AzureSpeechToCaptionsApi
    {
        private readonly IAzureSpeechToCaptionsApiClient _apiClient;

        public AzureSpeechToCaptionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAzureSpeechToCaptionsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AzureSpeechToCaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<AzureSpeechToCaptionsApi> Builder => new BitmovinApiBuilder<AzureSpeechToCaptionsApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Azure Speech to captions Filter
        /// </summary>
        /// <param name="azureSpeechToCaptionsFilter">The Azure Speech to captions Filter to be created</param>
        public async Task<Models.AzureSpeechToCaptionsFilter> CreateAsync(Models.AzureSpeechToCaptionsFilter azureSpeechToCaptionsFilter)
        {
            return await _apiClient.CreateAsync(azureSpeechToCaptionsFilter);
        }

        /// <summary>
        /// Delete Azure Speech to captions Filter
        /// </summary>
        /// <param name="filterId">Id of the Azure Speech to captions Filter. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Azure Speech to captions Filter details
        /// </summary>
        /// <param name="filterId">Id of the Azure Speech to captions Filter. (required)</param>
        public async Task<Models.AzureSpeechToCaptionsFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Azure Speech to captions Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AzureSpeechToCaptionsFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAzureSpeechToCaptionsApiClient
        {
            [Post("/encoding/filters/azure-speech-to-captions")]
            [AllowAnyStatusCode]
            Task<Models.AzureSpeechToCaptionsFilter> CreateAsync([Body] Models.AzureSpeechToCaptionsFilter azureSpeechToCaptionsFilter);

            [Delete("/encoding/filters/azure-speech-to-captions/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/azure-speech-to-captions/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.AzureSpeechToCaptionsFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/azure-speech-to-captions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AzureSpeechToCaptionsFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

            /// <summary>
            /// Filter filters by name
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

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
