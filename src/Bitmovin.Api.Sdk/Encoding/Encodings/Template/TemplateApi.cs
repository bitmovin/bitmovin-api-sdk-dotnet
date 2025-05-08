using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Template
{
    public class TemplateApi
    {
        private readonly ITemplateApiClient _apiClient;

        public TemplateApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITemplateApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TemplateApi
        /// </summary>
        public static BitmovinApiBuilder<TemplateApi> Builder => new BitmovinApiBuilder<TemplateApi>();

        /// <summary>
        /// Encoding Template URL
        /// </summary>
        /// <param name="encodingId">Id of the Encoding (required)</param>
        public async Task<Models.EncodingTemplateUrlResponse> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface ITemplateApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/template")]
            [AllowAnyStatusCode]
            Task<Models.EncodingTemplateUrlResponse> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
