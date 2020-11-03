using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Information;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4
{
    public class Fmp4Api
    {
        private readonly IFmp4ApiClient _apiClient;

        public Fmp4Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IFmp4ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
            Information = new InformationApi(apiClientFactory);
            Drm = new DrmApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Fmp4Api
        /// </summary>
        public static BitmovinApiBuilder<Fmp4Api> Builder => new BitmovinApiBuilder<Fmp4Api>();

        public CustomdataApi Customdata { get; }
        public InformationApi Information { get; }
        public DrmApi Drm { get; }

        /// <summary>
        /// Add fMP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="fmp4Muxing">The fMP4 muxing to be created</param>
        public async Task<Models.Fmp4Muxing> CreateAsync(string encodingId, Models.Fmp4Muxing fmp4Muxing)
        {
            return await _apiClient.CreateAsync(encodingId, fmp4Muxing);
        }

        /// <summary>
        /// Delete fMP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the fMP4 muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// fMP4 muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the fMP4 muxing (required)</param>
        public async Task<Models.Fmp4Muxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List fMP4 muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Fmp4Muxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IFmp4ApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/fmp4")]
            [AllowAnyStatusCode]
            Task<Models.Fmp4Muxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Fmp4Muxing fmp4Muxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.Fmp4Muxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Fmp4Muxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
