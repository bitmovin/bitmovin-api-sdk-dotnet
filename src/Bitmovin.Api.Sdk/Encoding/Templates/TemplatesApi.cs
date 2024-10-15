using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Templates
{
    public class TemplatesApi
    {
        private readonly ITemplatesApiClient _apiClient;

        public TemplatesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITemplatesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TemplatesApi
        /// </summary>
        public static BitmovinApiBuilder<TemplatesApi> Builder => new BitmovinApiBuilder<TemplatesApi>();

        /// <summary>
        /// BETA: Start an Encoding defined with an Encoding Template
        /// </summary>
        /// <param name="encodingTemplateRequest">The Encoding Template to start an Encoding from</param>
        public async Task<Models.EncodingTemplateStartResponse> StartAsync(object encodingTemplateRequest)
        {
            return await _apiClient.StartAsync(encodingTemplateRequest);
        }

        internal interface ITemplatesApiClient
        {
            [Post("/encoding/templates/start")]
            [AllowAnyStatusCode]
            Task<Models.EncodingTemplateStartResponse> StartAsync([Body] object encodingTemplateRequest);
        }
    }
}
