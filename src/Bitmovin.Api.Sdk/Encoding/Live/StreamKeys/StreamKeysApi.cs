using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Live.StreamKeys.Actions;

namespace Bitmovin.Api.Sdk.Encoding.Live.StreamKeys
{
    /// <summary>
    /// API for StreamKeysApi
    /// </summary>
    public class StreamKeysApi
    {
        private readonly IStreamKeysApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the StreamKeysApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public StreamKeysApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStreamKeysApiClient>();
            Actions = new ActionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of StreamKeysApi
        /// </summary>
        public static BitmovinApiBuilder<StreamKeysApi> Builder => new BitmovinApiBuilder<StreamKeysApi>();

        /// <summary>
        /// Gets the Actions API
        /// </summary>
        public ActionsApi Actions { get; }

        /// <summary>
        /// Create new stream key
        /// </summary>
        /// <param name="streamKey">The stream key to be created</param>
        public async Task<Models.StreamKey> CreateAsync(Models.StreamKey streamKey)
        {
            return await _apiClient.CreateAsync(streamKey);
        }

        /// <summary>
        /// Delete Stream Key
        /// </summary>
        /// <param name="streamKeyId">Id of the stream key (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string streamKeyId)
        {
            return await _apiClient.DeleteAsync(streamKeyId);
        }

        /// <summary>
        /// Stream Key details
        /// </summary>
        /// <param name="streamKeyId">Id of the stream key (required)</param>
        public async Task<Models.StreamKey> GetAsync(string streamKeyId)
        {
            return await _apiClient.GetAsync(streamKeyId);
        }

        /// <summary>
        /// List Stream Keys
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StreamKey>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IStreamKeysApiClient
        {
            [Post("/encoding/live/stream-keys")]
            [AllowAnyStatusCode]
            Task<Models.StreamKey> CreateAsync([Body] Models.StreamKey streamKey);

            [Delete("/encoding/live/stream-keys/{stream_key_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("stream_key_id")] string streamKeyId);

            [Get("/encoding/live/stream-keys/{stream_key_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamKey> GetAsync([Path("stream_key_id")] string streamKeyId);

            [Get("/encoding/live/stream-keys")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StreamKey>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Order list result according a stream key attribute.  The fields that can be used for sorting are: + &#x60;createdAt&#x60; + &#x60;name&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

            /// <summary>
            /// Filter stream keys by type
            /// </summary>
            public ListQueryParams Type(string type) => SetQueryParam("type", type);

            /// <summary>
            /// Filter stream keys by status
            /// </summary>
            public ListQueryParams Status(string status) => SetQueryParam("status", status);

            /// <summary>
            /// Filter stream keys by assigned ingest point id
            /// </summary>
            public ListQueryParams AssignedIngestPointId(string assignedIngestPointId) => SetQueryParam("assignedIngestPointId", assignedIngestPointId);

            /// <summary>
            /// Filter stream keys by assigned encoding id
            /// </summary>
            public ListQueryParams AssignedEncodingId(string assignedEncodingId) => SetQueryParam("assignedEncodingId", assignedEncodingId);

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
