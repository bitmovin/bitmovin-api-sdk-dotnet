using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Live.StreamKeys;

namespace Bitmovin.Api.Sdk.Encoding.Live
{
    public class LiveApi
    {
        public LiveApi(IBitmovinApiClientFactory apiClientFactory)
        {
            StreamKeys = new StreamKeysApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveApi
        /// </summary>
        public static BitmovinApiBuilder<LiveApi> Builder => new BitmovinApiBuilder<LiveApi>();

        public StreamKeysApi StreamKeys { get; }
    }
}
