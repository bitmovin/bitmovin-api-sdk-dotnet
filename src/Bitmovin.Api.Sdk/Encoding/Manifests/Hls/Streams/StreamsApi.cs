using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Streams.CustomTags;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Streams.Iframe;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Streams
{
    public class StreamsApi
    {
        private readonly IStreamsApiClient _apiClient;

        public StreamsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStreamsApiClient>();

            CustomTags = new CustomTagsApi(apiClientFactory);
            Iframe = new IframeApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of StreamsApi
        /// </summary>
        public static BitmovinApiBuilder<StreamsApi> Builder => new BitmovinApiBuilder<StreamsApi>();

        public CustomTagsApi CustomTags { get; private set; }
        public IframeApi Iframe { get; private set; }
        
        /// <summary>
        /// Add Variant Stream
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="streamInfo">The request payload</param>
        public async Task<Models.StreamInfo> CreateAsync(string manifestId, Models.StreamInfo streamInfo)
        {
            return await _apiClient.CreateAsync(manifestId, streamInfo);
        }
        
        /// <summary>
        /// Delete Variant Stream
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="streamId">Id of the variant stream.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string streamId)
        {
            return await _apiClient.DeleteAsync(manifestId, streamId);
        }
        
        /// <summary>
        /// Variant Stream Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="streamId">Id of the variant stream.</param>
        public async Task<Models.StreamInfo> GetAsync(string manifestId, string streamId)
        {
            return await _apiClient.GetAsync(manifestId, streamId);
        }
        
        /// <summary>
        /// List all Variant Streams
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StreamInfo>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }
        
        internal interface IStreamsApiClient
        {
            
            [Post("/encoding/manifests/hls/{manifest_id}/streams")]
            [AllowAnyStatusCode]
            Task<Models.StreamInfo> CreateAsync([Path("manifest_id")] string manifestId, [Body] Models.StreamInfo streamInfo);
            
            [Delete("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamInfo> GetAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/streams")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StreamInfo>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
