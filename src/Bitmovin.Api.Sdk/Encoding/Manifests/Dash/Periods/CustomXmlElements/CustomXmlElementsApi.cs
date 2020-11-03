using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.CustomXmlElements
{
    public class CustomXmlElementsApi
    {
        private readonly ICustomXmlElementsApiClient _apiClient;

        public CustomXmlElementsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomXmlElementsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomXmlElementsApi
        /// </summary>
        public static BitmovinApiBuilder<CustomXmlElementsApi> Builder => new BitmovinApiBuilder<CustomXmlElementsApi>();

        /// <summary>
        /// Add Custom XML Element to Period
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="customXmlElement">Data of the custom XML element to be added to the period</param>
        public async Task<Models.CustomXmlElement> CreateAsync(string manifestId, string periodId, Models.CustomXmlElement customXmlElement)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, customXmlElement);
        }

        /// <summary>
        /// Delete Custom XML Element
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="customXmlElementId">Id of the Custom XML Element (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string customXmlElementId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, customXmlElementId);
        }

        /// <summary>
        /// Custom XML Element Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="customXmlElementId">Id of the Custom XML Element (required)</param>
        public async Task<Models.CustomXmlElement> GetAsync(string manifestId, string periodId, string customXmlElementId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, customXmlElementId);
        }

        /// <summary>
        /// List all Custom XML Elements of Period
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CustomXmlElement>> ListAsync(string manifestId, string periodId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, q);
        }

        internal interface ICustomXmlElementsApiClient
        {
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/custom-xml-elements")]
            [AllowAnyStatusCode]
            Task<Models.CustomXmlElement> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Body] Models.CustomXmlElement customXmlElement);

            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/custom-xml-elements/{custom_xml_element_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("custom_xml_element_id")] string customXmlElementId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/custom-xml-elements/{custom_xml_element_id}")]
            [AllowAnyStatusCode]
            Task<Models.CustomXmlElement> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("custom_xml_element_id")] string customXmlElementId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/custom-xml-elements")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CustomXmlElement>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
