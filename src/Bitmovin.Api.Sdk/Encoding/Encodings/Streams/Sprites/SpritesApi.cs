using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Sprites.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Sprites
{
    public class SpritesApi
    {
        private readonly ISpritesApiClient _apiClient;

        public SpritesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISpritesApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SpritesApi
        /// </summary>
        public static BitmovinApiBuilder<SpritesApi> Builder => new BitmovinApiBuilder<SpritesApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Add Sprite
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="sprite">The request payload</param>
        public async Task<Models.Sprite> CreateAsync(string encodingId, string streamId, Models.Sprite sprite)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, sprite);
        }
        
        /// <summary>
        /// Delete Sprite
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="spriteId">Id of the sprite.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string spriteId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, spriteId);
        }
        
        /// <summary>
        /// Sprite Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="spriteId">Id of the sprite configuration.</param>
        public async Task<Models.Sprite> GetAsync(string encodingId, string streamId, string spriteId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, spriteId);
        }
        
        /// <summary>
        /// List Sprites
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
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
            Task<Models.PaginationResponse<Models.Sprite>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
