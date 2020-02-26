using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks
{
    public class WebhooksApi
    {
        public WebhooksApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Encoding = new EncodingApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WebhooksApi
        /// </summary>
        public static BitmovinApiBuilder<WebhooksApi> Builder => new BitmovinApiBuilder<WebhooksApi>();

        public EncodingApi Encoding { get; }
    }
}
