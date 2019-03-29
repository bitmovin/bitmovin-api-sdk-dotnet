using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Emails.Encoding.Encodings.LiveInputStreamChanged;
using Bitmovin.Api.Sdk.Notifications.Emails.Encoding.Encodings.Error;

namespace Bitmovin.Api.Sdk.Notifications.Emails.Encoding.Encodings
{
    public class EncodingsApi
    {
        private readonly IEncodingsApiClient _apiClient;

        public EncodingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEncodingsApiClient>();

            LiveInputStreamChanged = new LiveInputStreamChangedApi(apiClientFactory);
            Error = new ErrorApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingsApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingsApi> Builder => new BitmovinApiBuilder<EncodingsApi>();

        public LiveInputStreamChangedApi LiveInputStreamChanged { get; private set; }
        public ErrorApi Error { get; private set; }
        
        /// <summary>
        /// List Email Notifications (Specific Encoding)
        /// </summary>
        /// <param name="encodingId">Id of the encoding resource</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.EmailNotificationWithStreamConditions>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IEncodingsApiClient
        {
            
            [Get("/notifications/emails/encoding/encodings/{encoding_id}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EmailNotificationWithStreamConditions>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
