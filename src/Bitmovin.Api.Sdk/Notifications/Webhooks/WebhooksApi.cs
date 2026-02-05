using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks
{
    /// <summary>
    /// API for WebhooksApi
    /// </summary>
    public class WebhooksApi
    {
        /// <summary>
        /// Initializes a new instance of the WebhooksApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public WebhooksApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Encoding = new EncodingApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WebhooksApi
        /// </summary>
        public static BitmovinApiBuilder<WebhooksApi> Builder => new BitmovinApiBuilder<WebhooksApi>();

        /// <summary>
        /// Gets the Encoding API
        /// </summary>
        public EncodingApi Encoding { get; }
    }
}
