using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mxf.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mxf
{
    /// <summary>
    /// API for MxfApi
    /// </summary>
    public class MxfApi
    {
        private readonly IMxfApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the MxfApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public MxfApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMxfApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MxfApi
        /// </summary>
        public static BitmovinApiBuilder<MxfApi> Builder => new BitmovinApiBuilder<MxfApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add MXF muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="mxfMuxing">The MXF muxing to be created</param>
        public async Task<Models.MxfMuxing> CreateAsync(string encodingId, Models.MxfMuxing mxfMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, mxfMuxing);
        }

        /// <summary>
        /// Delete MXF muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the MXF muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// MXF muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the MXF muxing (required)</param>
        public async Task<Models.MxfMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List MXF muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.MxfMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IMxfApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/mxf")]
            [AllowAnyStatusCode]
            Task<Models.MxfMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.MxfMuxing mxfMuxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/mxf/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/mxf/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.MxfMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/mxf")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.MxfMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
