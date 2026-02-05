using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Sprites.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Sprites
{
    /// <summary>
    /// API for SpritesApi
    /// </summary>
    public class SpritesApi
    {
        private readonly ISpritesApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the SpritesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SpritesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISpritesApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SpritesApi
        /// </summary>
        public static BitmovinApiBuilder<SpritesApi> Builder => new BitmovinApiBuilder<SpritesApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add Sprite
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="sprite">The Sprite to be added</param>
        public async Task<Models.Sprite> CreateAsync(string encodingId, string streamId, Models.Sprite sprite)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, sprite);
        }

        /// <summary>
        /// Delete Sprite
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="spriteId">Id of the sprite. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string spriteId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, spriteId);
        }

        /// <summary>
        /// Sprite Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="spriteId">Id of the sprite configuration. (required)</param>
        public async Task<Models.Sprite> GetAsync(string encodingId, string streamId, string spriteId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, spriteId);
        }

        /// <summary>
        /// List Sprites
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Sprite>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface ISpritesApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/sprites")]
            [AllowAnyStatusCode]
            Task<Models.Sprite> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.Sprite sprite);

            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/sprites/{sprite_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("sprite_id")] string spriteId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/sprites/{sprite_id}")]
            [AllowAnyStatusCode]
            Task<Models.Sprite> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("sprite_id")] string spriteId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/sprites")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Sprite>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
