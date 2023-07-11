using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams.Video
{
    public class VideoApi
    {
        private readonly IVideoApiClient _apiClient;

        public VideoApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVideoApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of VideoApi
        /// </summary>
        public static BitmovinApiBuilder<VideoApi> Builder => new BitmovinApiBuilder<VideoApi>();

        /// <summary>
        /// Create new Streams video
        /// </summary>
        /// <param name="streamsVideoCreateRequest">Create a new stream.</param>
        public async Task<Models.StreamsVideoResponse> CreateAsync(Models.StreamsVideoCreateRequest streamsVideoCreateRequest)
        {
            return await _apiClient.CreateAsync(streamsVideoCreateRequest);
        }

        /// <summary>
        /// Get Streams video by id
        /// </summary>
        /// <param name="streamId">Id of the stream. (required)</param>
        public async Task<Models.StreamsVideoResponse> GetAsync(string streamId)
        {
            return await _apiClient.GetAsync(streamId);
        }

        /// <summary>
        /// Get paginated list of Streams videos
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StreamsVideoResponse>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Partially update video stream by id
        /// </summary>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="streamsVideoUpdateRequest">Stream fields to update.</param>
        public async Task<Models.StreamsVideoResponse> PatchStreamsVideoAsync(string streamId, Models.StreamsVideoUpdateRequest streamsVideoUpdateRequest)
        {
            return await _apiClient.PatchStreamsVideoAsync(streamId, streamsVideoUpdateRequest);
        }

        internal interface IVideoApiClient
        {
            [Post("/streams/video")]
            [AllowAnyStatusCode]
            Task<Models.StreamsVideoResponse> CreateAsync([Body] Models.StreamsVideoCreateRequest streamsVideoCreateRequest);

            [Get("/streams/video/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamsVideoResponse> GetAsync([Path("stream_id")] string streamId);

            [Get("/streams/video")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StreamsVideoResponse>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Patch("/streams/video/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamsVideoResponse> PatchStreamsVideoAsync([Path("stream_id")] string streamId, [Body] Models.StreamsVideoUpdateRequest streamsVideoUpdateRequest);
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
