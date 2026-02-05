using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.LiveMediaIngest.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.LiveMediaIngest
{
    /// <summary>
    /// API for LiveMediaIngestApi
    /// </summary>
    public class LiveMediaIngestApi
    {
        private readonly ILiveMediaIngestApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the LiveMediaIngestApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public LiveMediaIngestApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveMediaIngestApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveMediaIngestApi
        /// </summary>
        public static BitmovinApiBuilder<LiveMediaIngestApi> Builder => new BitmovinApiBuilder<LiveMediaIngestApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Live Media Ingest Output
        /// </summary>
        /// <param name="liveMediaIngestOutput">The Live Media Ingest output to be created</param>
        public async Task<Models.LiveMediaIngestOutput> CreateAsync(Models.LiveMediaIngestOutput liveMediaIngestOutput)
        {
            return await _apiClient.CreateAsync(liveMediaIngestOutput);
        }

        /// <summary>
        /// Delete Live Media Ingest Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// Live Media Ingest Output Details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
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
            Task<Models.PaginationResponse<Models.LiveMediaIngestOutput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

            /// <summary>
            /// Filter output by name
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
