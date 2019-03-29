using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Ttml.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Ttml
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
        /// Extract TTML Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="ttmlExtract">The request payload</param>
        public async Task<Models.TtmlExtract> CreateAsync(string encodingId, Models.TtmlExtract ttmlExtract)
        {
            return await _apiClient.CreateAsync(encodingId, ttmlExtract);
        }
        
        /// <summary>
        /// Delete TTML Extract Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="captionsId">Id of the captions configuration.</param>
        public async Task<Models.TtmlExtract> DeleteAsync(string encodingId, string captionsId)
        {
            return await _apiClient.DeleteAsync(encodingId, captionsId);
        }
        
        /// <summary>
        /// TTML Extract Captions Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="captionsId">Id of the captions.</param>
        public async Task<Models.TtmlExtract> GetAsync(string encodingId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, captionsId);
        }
        
        /// <summary>
        /// List TTML Extract Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.TtmlExtract>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface ITtmlApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/captions/ttml")]
            [AllowAnyStatusCode]
            Task<Models.TtmlExtract> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.TtmlExtract ttmlExtract);
            
            [Delete("/encoding/encodings/{encoding_id}/captions/ttml/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.TtmlExtract> DeleteAsync([Path("encoding_id")] string encodingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/ttml/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.TtmlExtract> GetAsync([Path("encoding_id")] string encodingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/ttml")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TtmlExtract>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
