using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Manifest;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding
{
    public class EncodingApi
    {
        public EncodingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Encodings = new EncodingsApi(apiClientFactory);
            Manifest = new ManifestApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingApi> Builder => new BitmovinApiBuilder<EncodingApi>();

        public EncodingsApi Encodings { get; private set; }
        public ManifestApi Manifest { get; private set; }

    }
}
