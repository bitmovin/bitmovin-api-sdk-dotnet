using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp3.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp3.Information;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp3
{
    public class Mp3Api
    {
        private readonly IMp3ApiClient _apiClient;

        public Mp3Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMp3ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
            Information = new InformationApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Mp3Api
        /// </summary>
        public static BitmovinApiBuilder<Mp3Api> Builder => new BitmovinApiBuilder<Mp3Api>();

        public CustomdataApi Customdata { get; }
        public InformationApi Information { get; }

        /// <summary>
        /// Add MP3 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="mp3Muxing">The MP3 muxing to be created</param>
        public async Task<Models.Mp3Muxing> CreateAsync(string encodingId, Models.Mp3Muxing mp3Muxing)
        {
            return await _apiClient.CreateAsync(encodingId, mp3Muxing);
        }

        /// <summary>
        /// Delete MP3 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the MP3 muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// MP3 muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the MP3 muxing (required)</param>
        public async Task<Models.Mp3Muxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List MP3 muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Mp3Muxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IMp3ApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/mp3")]
            [AllowAnyStatusCode]
            Task<Models.Mp3Muxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Mp3Muxing mp3Muxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/mp3/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/mp3/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.Mp3Muxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/mp3")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Mp3Muxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
