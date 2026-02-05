using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Templates
{
    /// <summary>
    /// API for TemplatesApi
    /// </summary>
    public class TemplatesApi
    {
        private readonly ITemplatesApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the TemplatesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public TemplatesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITemplatesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TemplatesApi
        /// </summary>
        public static BitmovinApiBuilder<TemplatesApi> Builder => new BitmovinApiBuilder<TemplatesApi>();

        /// <summary>
        /// Store an Encoding Template
        /// </summary>
        /// <param name="encodingTemplateRequest">The Encoding Template to be stored</param>
        public async Task<Models.EncodingTemplateDetails> CreateAsync(object encodingTemplateRequest)
        {
            return await _apiClient.CreateAsync(encodingTemplateRequest);
        }

        /// <summary>
        /// Delete Encoding Template
        /// </summary>
        /// <param name="encodingTemplateId">Id of the encoding template to delete (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingTemplateId)
        {
            return await _apiClient.DeleteAsync(encodingTemplateId);
        }

        /// <summary>
        /// Encoding Template details
        /// </summary>
        /// <param name="encodingTemplateId">Id of the Encoding Template (required)</param>
        public async Task<Models.EncodingTemplateDetails> GetAsync(string encodingTemplateId)
        {
            return await _apiClient.GetAsync(encodingTemplateId);
        }

        /// <summary>
        /// List stored Encoding Templates
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.EncodingTemplateResponse>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Start an Encoding defined with an Encoding Template
        /// </summary>
        /// <param name="encodingTemplateRequest">The Encoding Template to start an Encoding from</param>
        public async Task<Models.EncodingTemplateStartResponse> StartAsync(object encodingTemplateRequest)
        {
            return await _apiClient.StartAsync(encodingTemplateRequest);
        }

        internal interface ITemplatesApiClient
        {
            [Post("/encoding/templates")]
            [AllowAnyStatusCode]
            Task<Models.EncodingTemplateDetails> CreateAsync([Body] object encodingTemplateRequest);

            [Delete("/encoding/templates/{encoding_template_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_template_id")] string encodingTemplateId);

            [Get("/encoding/templates/{encoding_template_id}")]
            [AllowAnyStatusCode]
            Task<Models.EncodingTemplateDetails> GetAsync([Path("encoding_template_id")] string encodingTemplateId);

            [Get("/encoding/templates")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EncodingTemplateResponse>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Post("/encoding/templates/start")]
            [AllowAnyStatusCode]
            Task<Models.EncodingTemplateStartResponse> StartAsync([Body] object encodingTemplateRequest);
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

            /// <summary>
            /// Filter the stored templates by type
            /// </summary>
            public ListQueryParams Type(Models.EncodingTemplateType type) => SetQueryParam("type", type);

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
