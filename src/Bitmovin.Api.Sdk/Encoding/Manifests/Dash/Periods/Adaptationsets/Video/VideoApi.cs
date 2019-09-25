using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Video
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
        /// Add Video AdaptationSet
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="videoAdaptationSet">The request payload</param>
        public async Task<Models.VideoAdaptationSet> CreateAsync(string manifestId, string periodId, Models.VideoAdaptationSet videoAdaptationSet)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, videoAdaptationSet);
        }
        
        /// <summary>
        /// Delete Video AdaptationSet
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="adaptationsetId">Id of the video adaptation set to be deleted</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string adaptationsetId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, adaptationsetId);
        }
        
        /// <summary>
        /// Video AdaptationSet Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="adaptationsetId">Id of the video adaptation set</param>
        public async Task<Models.VideoAdaptationSet> GetAsync(string manifestId, string periodId, string adaptationsetId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId);
        }
        
        /// <summary>
        /// List all Video AdaptationSets
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.VideoAdaptationSet>> ListAsync(string manifestId, string periodId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, q);
        }
        
        internal interface IVideoApiClient
        {
            
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/video")]
            [AllowAnyStatusCode]
            Task<Models.VideoAdaptationSet> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Body] Models.VideoAdaptationSet videoAdaptationSet);
            
            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/video/{adaptationset_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId);
            
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/video/{adaptationset_id}")]
            [AllowAnyStatusCode]
            Task<Models.VideoAdaptationSet> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId);
            
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/video")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.VideoAdaptationSet>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
