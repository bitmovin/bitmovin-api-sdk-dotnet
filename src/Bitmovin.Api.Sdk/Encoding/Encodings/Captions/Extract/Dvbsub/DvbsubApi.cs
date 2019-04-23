using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Dvbsub.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Dvbsub
{
    public class DvbsubApi
    {
        private readonly IDvbsubApiClient _apiClient;

        public DvbsubApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDvbsubApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DvbsubApi
        /// </summary>
        public static BitmovinApiBuilder<DvbsubApi> Builder => new BitmovinApiBuilder<DvbsubApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Extract DVB-SUB Subtitle
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="dvbSubtitleSidecarDetails">The request payload</param>
        public async Task<Models.DvbSubtitleSidecarDetails> CreateAsync(string encodingId, Models.DvbSubtitleSidecarDetails dvbSubtitleSidecarDetails)
        {
            return await _apiClient.CreateAsync(encodingId, dvbSubtitleSidecarDetails);
        }
        
        /// <summary>
        /// Delete Extract DVB-SUB Subtitle
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="subtitleId">Id of the subtitle.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string subtitleId)
        {
            return await _apiClient.DeleteAsync(encodingId, subtitleId);
        }
        
        /// <summary>
        /// Get Extract Subtitle DVB-SUB Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="subtitleId">Id of the subtitle.</param>
        public async Task<Models.DvbSubtitleSidecarDetails> GetAsync(string encodingId, string subtitleId)
        {
            return await _apiClient.GetAsync(encodingId, subtitleId);
        }
        
        /// <summary>
        /// List Extract DVB-SUB Subtitle
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DvbSubtitleSidecarDetails>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IDvbsubApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/captions/extract/dvbsub")]
            [AllowAnyStatusCode]
            Task<Models.DvbSubtitleSidecarDetails> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.DvbSubtitleSidecarDetails dvbSubtitleSidecarDetails);
            
            [Delete("/encoding/encodings/{encoding_id}/captions/extract/dvbsub/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("subtitle_id")] string subtitleId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/extract/dvbsub/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.DvbSubtitleSidecarDetails> GetAsync([Path("encoding_id")] string encodingId, [Path("subtitle_id")] string subtitleId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/extract/dvbsub")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DvbSubtitleSidecarDetails>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
