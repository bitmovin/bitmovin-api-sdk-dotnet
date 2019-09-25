using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Scc.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Scc
{
    public class SccApi
    {
        private readonly ISccApiClient _apiClient;

        public SccApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISccApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SccApi
        /// </summary>
        public static BitmovinApiBuilder<SccApi> Builder => new BitmovinApiBuilder<SccApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Convert SCC captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="convertSccCaption">The request payload</param>
        public async Task<Models.ConvertSccCaption> CreateAsync(string encodingId, Models.ConvertSccCaption convertSccCaption)
        {
            return await _apiClient.CreateAsync(encodingId, convertSccCaption);
        }
        
        /// <summary>
        /// Delete Convert SCC captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="captionsId">Id of the caption.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string captionsId)
        {
            return await _apiClient.DeleteAsync(encodingId, captionsId);
        }
        
        /// <summary>
        /// Convert SCC captions Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="captionsId">Id of the caption.</param>
        public async Task<Models.ConvertSccCaption> GetAsync(string encodingId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, captionsId);
        }
        
        /// <summary>
        /// List Convert SCC captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ConvertSccCaption>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface ISccApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/captions/scc")]
            [AllowAnyStatusCode]
            Task<Models.ConvertSccCaption> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ConvertSccCaption convertSccCaption);
            
            [Delete("/encoding/encodings/{encoding_id}/captions/scc/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/scc/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.ConvertSccCaption> GetAsync([Path("encoding_id")] string encodingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/scc")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ConvertSccCaption>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
