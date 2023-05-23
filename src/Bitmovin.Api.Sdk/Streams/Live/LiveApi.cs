using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Streams.Live.Stop;
using Bitmovin.Api.Sdk.Streams.Live.Start;

namespace Bitmovin.Api.Sdk.Streams.Live
{
    public class LiveApi
    {
        private readonly ILiveApiClient _apiClient;

        public LiveApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveApiClient>();
            Stop = new StopApi(apiClientFactory);
            Start = new StartApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveApi
        /// </summary>
        public static BitmovinApiBuilder<LiveApi> Builder => new BitmovinApiBuilder<LiveApi>();

        public StopApi Stop { get; }
        public StartApi Start { get; }

        /// <summary>
        /// Create new live stream
        /// </summary>
        /// <param name="streamsLiveCreateRequest">Create a new stream.</param>
        public async Task<Models.StreamsLiveResponse> CreateAsync(Models.StreamsLiveCreateRequest streamsLiveCreateRequest)
        {
            return await _apiClient.CreateAsync(streamsLiveCreateRequest);
        }

        /// <summary>
        /// Get live stream by id
        /// </summary>
        /// <param name="streamId">Id of the stream. (required)</param>
        public async Task<Models.StreamsLiveResponse> GetAsync(string streamId)
        {
            return await _apiClient.GetAsync(streamId);
        }

        /// <summary>
        /// Get paginated list of live streams
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StreamsLiveResponse>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Partially update live stream by id
        /// </summary>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="streamsLiveUpdateRequest">Stream fields to update.</param>
        public async Task<Models.StreamsLiveResponse> PatchStreamsLiveAsync(string streamId, Models.StreamsLiveUpdateRequest streamsLiveUpdateRequest)
        {
            return await _apiClient.PatchStreamsLiveAsync(streamId, streamsLiveUpdateRequest);
        }

        /// <summary>
        /// Update live stream by id
        /// </summary>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="streamsLiveUpdateRequest">The updated stream config object.</param>
        public async Task<Models.StreamsLiveResponse> UpdateAsync(string streamId, Models.StreamsLiveUpdateRequest streamsLiveUpdateRequest)
        {
            return await _apiClient.UpdateAsync(streamId, streamsLiveUpdateRequest);
        }

        internal interface ILiveApiClient
        {
            [Post("/streams/live")]
            [AllowAnyStatusCode]
            Task<Models.StreamsLiveResponse> CreateAsync([Body] Models.StreamsLiveCreateRequest streamsLiveCreateRequest);

            [Get("/streams/live/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamsLiveResponse> GetAsync([Path("stream_id")] string streamId);

            [Get("/streams/live")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StreamsLiveResponse>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Patch("/streams/live/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamsLiveResponse> PatchStreamsLiveAsync([Path("stream_id")] string streamId, [Body] Models.StreamsLiveUpdateRequest streamsLiveUpdateRequest);

            [Put("/streams/live/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamsLiveResponse> UpdateAsync([Path("stream_id")] string streamId, [Body] Models.StreamsLiveUpdateRequest streamsLiveUpdateRequest);
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
            /// Order list result according an resource attribute. The fields that can be used for sorting are: + &#x60;createdAt&#x60; 
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
