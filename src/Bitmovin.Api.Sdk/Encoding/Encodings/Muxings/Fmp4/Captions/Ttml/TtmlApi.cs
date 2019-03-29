using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Captions.Ttml.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Captions.Ttml
{
    public class TtmlApi
    {
        private readonly ITtmlApiClient _apiClient;

        public TtmlApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITtmlApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of TtmlApi
        /// </summary>
        public static BitmovinApiBuilder<TtmlApi> Builder => new BitmovinApiBuilder<TtmlApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// FMP4 Embed TTML Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fMP4 muxing.</param>
        /// <param name="ttmlEmbed">The request payload</param>
        public async Task<Models.TtmlEmbed> CreateAsync(string encodingId, string muxingId, Models.TtmlEmbed ttmlEmbed)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, ttmlEmbed);
        }
        
        /// <summary>
        /// Delete TTML Embed Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fMP4 muxing.</param>
        /// <param name="captionsId">Id of the captions configuration.</param>
        public async Task<Models.TtmlEmbed> DeleteAsync(string encodingId, string muxingId, string captionsId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, captionsId);
        }
        
        /// <summary>
        /// TTML Embed Captions Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fMP4 muxing.</param>
        /// <param name="captionsId">Id of the captions.</param>
        public async Task<Models.TtmlEmbed> GetAsync(string encodingId, string muxingId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, captionsId);
        }
        
        /// <summary>
        /// List TTML Embed Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fMP4 muxing.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.TtmlEmbed>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }
        
        internal interface ITtmlApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/captions/ttml")]
            [AllowAnyStatusCode]
            Task<Models.TtmlEmbed> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.TtmlEmbed ttmlEmbed);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/captions/ttml/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.TtmlEmbed> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/captions/ttml/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.TtmlEmbed> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/captions/ttml")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TtmlEmbed>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
