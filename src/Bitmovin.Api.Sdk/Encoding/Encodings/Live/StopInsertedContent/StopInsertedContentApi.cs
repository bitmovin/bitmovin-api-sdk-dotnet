using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.StopInsertedContent
{
    public class StopInsertedContentApi
    {
        private readonly IStopInsertedContentApiClient _apiClient;

        public StopInsertedContentApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStopInsertedContentApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of StopInsertedContentApi
        /// </summary>
        public static BitmovinApiBuilder<StopInsertedContentApi> Builder => new BitmovinApiBuilder<StopInsertedContentApi>();

        
        /// <summary>
        /// Stop Currently Running Inserted Content
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        public async Task CreateAsync(string encodingId)
        {
            await _apiClient.CreateAsync(encodingId);
        }
        
        internal interface IStopInsertedContentApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/live/stop-inserted-content")]
            [AllowAnyStatusCode]
            Task CreateAsync([Path("encoding_id")] string encodingId);
            
        }
        
    }
}
