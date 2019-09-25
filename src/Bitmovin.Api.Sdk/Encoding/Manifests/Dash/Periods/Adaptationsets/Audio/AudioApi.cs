using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Audio
{
    public class AudioApi
    {
        private readonly IAudioApiClient _apiClient;

        public AudioApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAudioApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of AudioApi
        /// </summary>
        public static BitmovinApiBuilder<AudioApi> Builder => new BitmovinApiBuilder<AudioApi>();

        
        /// <summary>
        /// Add Audio AdaptationSet
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="audioAdaptationSet">The request payload</param>
        public async Task<Models.AudioAdaptationSet> CreateAsync(string manifestId, string periodId, Models.AudioAdaptationSet audioAdaptationSet)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, audioAdaptationSet);
        }
        
        /// <summary>
        /// Delete Audio AdaptationSet
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="adaptationsetId">Id of the audio adaptation set to be deleted</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string adaptationsetId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, adaptationsetId);
        }
        
        /// <summary>
        /// Audio AdaptationSet Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="adaptationsetId">Id of the audio adaptation set</param>
        public async Task<Models.AudioAdaptationSet> GetAsync(string manifestId, string periodId, string adaptationsetId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId);
        }
        
        /// <summary>
        /// List all Audio AdaptationSets
        /// </summary>
        /// <param name="manifestId">Id of the manifest</param>
        /// <param name="periodId">Id of the period</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AudioAdaptationSet>> ListAsync(string manifestId, string periodId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, q);
        }
        
        internal interface IAudioApiClient
        {
            
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/audio")]
            [AllowAnyStatusCode]
            Task<Models.AudioAdaptationSet> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Body] Models.AudioAdaptationSet audioAdaptationSet);
            
            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/audio/{adaptationset_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId);
            
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/audio/{adaptationset_id}")]
            [AllowAnyStatusCode]
            Task<Models.AudioAdaptationSet> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId);
            
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/audio")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AudioAdaptationSet>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
