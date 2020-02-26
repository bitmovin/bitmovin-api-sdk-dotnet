using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Representations.Mp4
{
    public class Mp4Api
    {
        private readonly IMp4ApiClient _apiClient;

        public Mp4Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMp4ApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of Mp4Api
        /// </summary>
        public static BitmovinApiBuilder<Mp4Api> Builder => new BitmovinApiBuilder<Mp4Api>();

        /// <summary>
        /// Add MP4 Representation to Smooth Streaming Manifest
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming manifest. (required)</param>
        /// <param name="smoothStreamingRepresentation">The MP4 Representation to be added</param>
        public async Task<Models.SmoothStreamingRepresentation> CreateAsync(string manifestId, Models.SmoothStreamingRepresentation smoothStreamingRepresentation)
        {
            return await _apiClient.CreateAsync(manifestId, smoothStreamingRepresentation);
        }

        /// <summary>
        /// Delete Smooth Streaming MP4 Representation
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming manifest. (required)</param>
        /// <param name="representationId">Id of the MP4 representation. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string representationId)
        {
            return await _apiClient.DeleteAsync(manifestId, representationId);
        }

        /// <summary>
        /// Smooth Streaming MP4 Representation Details
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming manifest. (required)</param>
        /// <param name="representationId">Id of the MP4 representation. (required)</param>
        public async Task<Models.SmoothStreamingRepresentation> GetAsync(string manifestId, string representationId)
        {
            return await _apiClient.GetAsync(manifestId, representationId);
        }

        /// <summary>
        /// List MP4 Representation
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming manifest. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SmoothStreamingRepresentation>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }

        internal interface IMp4ApiClient
        {
            [Post("/encoding/manifests/smooth/{manifest_id}/representations/mp4")]
            [AllowAnyStatusCode]
            Task<Models.SmoothStreamingRepresentation> CreateAsync([Path("manifest_id")] string manifestId, [Body] Models.SmoothStreamingRepresentation smoothStreamingRepresentation);

            [Delete("/encoding/manifests/smooth/{manifest_id}/representations/mp4/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("representation_id")] string representationId);

            [Get("/encoding/manifests/smooth/{manifest_id}/representations/mp4/{representation_id}")]
            [AllowAnyStatusCode]
            Task<Models.SmoothStreamingRepresentation> GetAsync([Path("manifest_id")] string manifestId, [Path("representation_id")] string representationId);

            [Get("/encoding/manifests/smooth/{manifest_id}/representations/mp4")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SmoothStreamingRepresentation>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(long? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(long? limit) => SetQueryParam("limit", limit);

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
