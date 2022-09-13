using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams
{
    public class StreamsApi
    {
        private readonly IStreamsApiClient _apiClient;

        public StreamsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStreamsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of StreamsApi
        /// </summary>
        public static BitmovinApiBuilder<StreamsApi> Builder => new BitmovinApiBuilder<StreamsApi>();

        /// <summary>
        /// Create new Stream
        /// </summary>
        /// <param name="createBitmovinStreamRequest">Create a new Stream.</param>
        public async Task<Models.BitmovinStreamResponse> CreateAsync(Models.CreateBitmovinStreamRequest createBitmovinStreamRequest)
        {
            return await _apiClient.CreateAsync(createBitmovinStreamRequest);
        }

        /// <summary>
        /// Get Stream by id
        /// </summary>
        /// <param name="streamId">Id of the Stream. (required)</param>
        public async Task<Models.BitmovinStreamResponse> GetAsync(string streamId)
        {
            return await _apiClient.GetAsync(streamId);
        }

        /// <summary>
        /// Get paginated list of Streams
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.BitmovinStreamResponse>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Update Stream by id
        /// </summary>
        /// <param name="streamId">Id of the Stream. (required)</param>
        /// <param name="updateBitmovinStreamRequest">Stream fields to update.</param>
        public async Task<Models.BitmovinStreamResponse> PatchBitmovinStreamsStreamsByStreamIdAsync(string streamId, Models.UpdateBitmovinStreamRequest updateBitmovinStreamRequest)
        {
            return await _apiClient.PatchBitmovinStreamsStreamsByStreamIdAsync(streamId, updateBitmovinStreamRequest);
        }

        internal interface IStreamsApiClient
        {
            [Post("/streams")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinStreamResponse> CreateAsync([Body] Models.CreateBitmovinStreamRequest createBitmovinStreamRequest);

            [Get("/streams/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinStreamResponse> GetAsync([Path("stream_id")] string streamId);

            [Get("/streams")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.BitmovinStreamResponse>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Patch("/streams/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinStreamResponse> PatchBitmovinStreamsStreamsByStreamIdAsync([Path("stream_id")] string streamId, [Body] Models.UpdateBitmovinStreamRequest updateBitmovinStreamRequest);
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
            /// Order list result according an resource attribute.  The fields that can be used for sorting are: + &#x60;createdAt&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

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
