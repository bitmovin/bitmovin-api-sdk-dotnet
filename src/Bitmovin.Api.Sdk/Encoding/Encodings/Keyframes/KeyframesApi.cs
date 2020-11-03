using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Keyframes
{
    public class KeyframesApi
    {
        private readonly IKeyframesApiClient _apiClient;

        public KeyframesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IKeyframesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of KeyframesApi
        /// </summary>
        public static BitmovinApiBuilder<KeyframesApi> Builder => new BitmovinApiBuilder<KeyframesApi>();

        /// <summary>
        /// Create Keyframes
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="keyframe">The Keyframes to be created</param>
        public async Task<Models.Keyframe> CreateAsync(string encodingId, Models.Keyframe keyframe)
        {
            return await _apiClient.CreateAsync(encodingId, keyframe);
        }

        /// <summary>
        /// Delete Keyframe
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="keyframeId">Id of the keyframe. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string keyframeId)
        {
            return await _apiClient.DeleteAsync(encodingId, keyframeId);
        }

        /// <summary>
        /// Keyframe Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="keyframeId">Id of the keyframe. (required)</param>
        public async Task<Models.Keyframe> GetAsync(string encodingId, string keyframeId)
        {
            return await _apiClient.GetAsync(encodingId, keyframeId);
        }

        /// <summary>
        /// List all Keyframes
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Keyframe>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IKeyframesApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/keyframes")]
            [AllowAnyStatusCode]
            Task<Models.Keyframe> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Keyframe keyframe);

            [Delete("/encoding/encodings/{encoding_id}/keyframes/{keyframe_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("keyframe_id")] string keyframeId);

            [Get("/encoding/encodings/{encoding_id}/keyframes/{keyframe_id}")]
            [AllowAnyStatusCode]
            Task<Models.Keyframe> GetAsync([Path("encoding_id")] string encodingId, [Path("keyframe_id")] string keyframeId);

            [Get("/encoding/encodings/{encoding_id}/keyframes")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Keyframe>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
