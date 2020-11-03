using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Manifest.Error;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Manifest.Finished;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Manifest
{
    public class ManifestApi
    {
        private readonly IManifestApiClient _apiClient;

        public ManifestApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IManifestApiClient>();
            Error = new ErrorApi(apiClientFactory);
            Finished = new FinishedApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ManifestApi
        /// </summary>
        public static BitmovinApiBuilder<ManifestApi> Builder => new BitmovinApiBuilder<ManifestApi>();

        public ErrorApi Error { get; }
        public FinishedApi Finished { get; }

        /// <summary>
        /// List Webhook Notifications (Specific Manifest)
        /// </summary>
        /// <param name="manifestId">Id of the manifest resource (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Notification>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }

        internal interface IManifestApiClient
        {
            [Get("/notifications/webhooks/encoding/manifest/{manifest_id}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Notification>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
