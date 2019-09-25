using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.LiveMediaIngest.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.LiveMediaIngest
{
    public class LiveMediaIngestApi
    {
        private readonly ILiveMediaIngestApiClient _apiClient;

        public LiveMediaIngestApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveMediaIngestApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveMediaIngestApi
        /// </summary>
        public static BitmovinApiBuilder<LiveMediaIngestApi> Builder => new BitmovinApiBuilder<LiveMediaIngestApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Live Media Ingest Output
        /// </summary>
        /// <param name="liveMediaIngestOutput">The request payload</param>
        public async Task<Models.LiveMediaIngestOutput> CreateAsync(Models.LiveMediaIngestOutput liveMediaIngestOutput)
        {
            return await _apiClient.CreateAsync(liveMediaIngestOutput);
        }
        
        /// <summary>
        /// Delete Live Media Ingest Output
        /// </summary>
        /// <param name="outputId">Id of the output</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }
        
        /// <summary>
        /// Live Media Ingest Output Details
        /// </summary>
        /// <param name="outputId">Id of the output</param>
        public async Task<Models.LiveMediaIngestOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }
        
        /// <summary>
        /// List Live Media Ingest Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.LiveMediaIngestOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface ILiveMediaIngestApiClient
        {
            
            [Post("/encoding/outputs/live-media-ingest")]
            [AllowAnyStatusCode]
            Task<Models.LiveMediaIngestOutput> CreateAsync([Body] Models.LiveMediaIngestOutput liveMediaIngestOutput);
            
            [Delete("/encoding/outputs/live-media-ingest/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("output_id")] string outputId);
            
            [Get("/encoding/outputs/live-media-ingest/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.LiveMediaIngestOutput> GetAsync([Path("output_id")] string outputId);
            
            [Get("/encoding/outputs/live-media-ingest")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.LiveMediaIngestOutput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
