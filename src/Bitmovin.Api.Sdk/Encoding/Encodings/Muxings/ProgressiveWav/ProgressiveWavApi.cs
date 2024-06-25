using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWav.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWav.Information;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWav
{
    public class ProgressiveWavApi
    {
        private readonly IProgressiveWavApiClient _apiClient;

        public ProgressiveWavApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IProgressiveWavApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
            Information = new InformationApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ProgressiveWavApi
        /// </summary>
        public static BitmovinApiBuilder<ProgressiveWavApi> Builder => new BitmovinApiBuilder<ProgressiveWavApi>();

        public CustomdataApi Customdata { get; }
        public InformationApi Information { get; }

        /// <summary>
        /// Add Progressive Wav muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="progressiveWavMuxing">The Progressive WAV muxing to be created</param>
        public async Task<Models.ProgressiveWavMuxing> CreateAsync(string encodingId, Models.ProgressiveWavMuxing progressiveWavMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, progressiveWavMuxing);
        }

        /// <summary>
        /// Delete Progressive WAV muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive WAV muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// Progressive WAV muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive WAV muxing (required)</param>
        public async Task<Models.ProgressiveWavMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List Progressive WAV muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ProgressiveWavMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IProgressiveWavApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/progressive-wav")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveWavMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ProgressiveWavMuxing progressiveWavMuxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/progressive-wav/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-wav/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveWavMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-wav")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ProgressiveWavMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
