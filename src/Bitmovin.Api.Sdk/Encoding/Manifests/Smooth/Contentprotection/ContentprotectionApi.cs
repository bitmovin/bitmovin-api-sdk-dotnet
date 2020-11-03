using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Contentprotection
{
    public class ContentprotectionApi
    {
        private readonly IContentprotectionApiClient _apiClient;

        public ContentprotectionApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IContentprotectionApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ContentprotectionApi
        /// </summary>
        public static BitmovinApiBuilder<ContentprotectionApi> Builder => new BitmovinApiBuilder<ContentprotectionApi>();

        /// <summary>
        /// Add Content Protection to Smooth Streaming
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming manifest. (required)</param>
        /// <param name="smoothManifestContentProtection">The Content Protection to be added</param>
        public async Task<Models.SmoothManifestContentProtection> CreateAsync(string manifestId, Models.SmoothManifestContentProtection smoothManifestContentProtection)
        {
            return await _apiClient.CreateAsync(manifestId, smoothManifestContentProtection);
        }

        /// <summary>
        /// Delete Content Protection of Smooth Streaming
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming manifest. (required)</param>
        /// <param name="protectionId">Id of the content protection. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string protectionId)
        {
            return await _apiClient.DeleteAsync(manifestId, protectionId);
        }

        /// <summary>
        /// Content Protection of Smooth Streaming Representation Details
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming manifest. (required)</param>
        /// <param name="protectionId">Id of the content protection. (required)</param>
        public async Task<Models.SmoothManifestContentProtection> GetAsync(string manifestId, string protectionId)
        {
            return await _apiClient.GetAsync(manifestId, protectionId);
        }

        /// <summary>
        /// List Content Protection of Smooth Streaming
        /// </summary>
        /// <param name="manifestId">Id of the Smooth Streaming manifest. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SmoothManifestContentProtection>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }

        internal interface IContentprotectionApiClient
        {
            [Post("/encoding/manifests/smooth/{manifest_id}/contentprotection")]
            [AllowAnyStatusCode]
            Task<Models.SmoothManifestContentProtection> CreateAsync([Path("manifest_id")] string manifestId, [Body] Models.SmoothManifestContentProtection smoothManifestContentProtection);

            [Delete("/encoding/manifests/smooth/{manifest_id}/contentprotection/{protection_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("protection_id")] string protectionId);

            [Get("/encoding/manifests/smooth/{manifest_id}/contentprotection/{protection_id}")]
            [AllowAnyStatusCode]
            Task<Models.SmoothManifestContentProtection> GetAsync([Path("manifest_id")] string manifestId, [Path("protection_id")] string protectionId);

            [Get("/encoding/manifests/smooth/{manifest_id}/contentprotection")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SmoothManifestContentProtection>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
