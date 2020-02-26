using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Emails.UsageReports;
using Bitmovin.Api.Sdk.Notifications.Emails.Encoding;

namespace Bitmovin.Api.Sdk.Notifications.Emails
{
    public class EmailsApi
    {
        private readonly IEmailsApiClient _apiClient;

        public EmailsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEmailsApiClient>();
            UsageReports = new UsageReportsApi(apiClientFactory);
            Encoding = new EncodingApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EmailsApi
        /// </summary>
        public static BitmovinApiBuilder<EmailsApi> Builder => new BitmovinApiBuilder<EmailsApi>();

        public UsageReportsApi UsageReports { get; }
        public EncodingApi Encoding { get; }

        /// <summary>
        /// List Email Notifications
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Notification>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IEmailsApiClient
        {
            [Get("/notifications/emails")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Notification>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
