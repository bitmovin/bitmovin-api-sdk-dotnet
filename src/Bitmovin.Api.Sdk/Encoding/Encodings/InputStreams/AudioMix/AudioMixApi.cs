using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.AudioMix
{
    public class AudioMixApi
    {
        private readonly IAudioMixApiClient _apiClient;

        public AudioMixApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAudioMixApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of AudioMixApi
        /// </summary>
        public static BitmovinApiBuilder<AudioMixApi> Builder => new BitmovinApiBuilder<AudioMixApi>();

        
        /// <summary>
        /// Add audio mix input stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="audioMixInputStream">The request payload</param>
        public async Task<Models.AudioMixInputStream> CreateAsync(string encodingId, Models.AudioMixInputStream audioMixInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, audioMixInputStream);
        }
        
        /// <summary>
        /// Delete audio mix input stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="inputStreamId">Id of the audio mix input stream.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }
        
        /// <summary>
        /// Audio mix input stream details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="inputStreamId">Id of the audio mix input stream.</param>
        public async Task<Models.AudioMixInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }
        
        /// <summary>
        /// List audio mix input stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AudioMixInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IAudioMixApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/input-streams/audio-mix")]
            [AllowAnyStatusCode]
            Task<Models.AudioMixInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.AudioMixInputStream audioMixInputStream);
            
            [Delete("/encoding/encodings/{encoding_id}/input-streams/audio-mix/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/audio-mix/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.AudioMixInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/audio-mix")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AudioMixInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
