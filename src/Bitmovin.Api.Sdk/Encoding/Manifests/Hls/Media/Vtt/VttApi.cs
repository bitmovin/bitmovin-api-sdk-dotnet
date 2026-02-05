using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Vtt
{
    /// <summary>
    /// API for VttApi
    /// </summary>
    public class VttApi
    {
        private readonly IVttApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the VttApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public VttApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVttApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of VttApi
        /// </summary>
        public static BitmovinApiBuilder<VttApi> Builder => new BitmovinApiBuilder<VttApi>();

        /// <summary>
        /// Add VTT Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="vttMediaInfo">The VTT Media to be added</param>
        public async Task<Models.VttMediaInfo> CreateAsync(string manifestId, Models.VttMediaInfo vttMediaInfo)
        {
            return await _apiClient.CreateAsync(manifestId, vttMediaInfo);
        }

        /// <summary>
        /// Delete VTT Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="mediaId">Id of the VTT media. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string mediaId)
        {
            return await _apiClient.DeleteAsync(manifestId, mediaId);
        }

        /// <summary>
        /// VTT Media Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="mediaId">Id of the VTT media. (required)</param>
        public async Task<Models.VttMediaInfo> GetAsync(string manifestId, string mediaId)
        {
            return await _apiClient.GetAsync(manifestId, mediaId);
        }

        /// <summary>
        /// List all VTT Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.VttMediaInfo>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }

        internal interface IVttApiClient
        {
            [Post("/encoding/manifests/hls/{manifest_id}/media/vtt")]
            [AllowAnyStatusCode]
            Task<Models.VttMediaInfo> CreateAsync([Path("manifest_id")] string manifestId, [Body] Models.VttMediaInfo vttMediaInfo);

            [Delete("/encoding/manifests/hls/{manifest_id}/media/vtt/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);

            [Get("/encoding/manifests/hls/{manifest_id}/media/vtt/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.VttMediaInfo> GetAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);

            [Get("/encoding/manifests/hls/{manifest_id}/media/vtt")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.VttMediaInfo>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
