using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Statistics.Cdn.Usage;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Cdn
{
    public class CdnApi
    {
        public CdnApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Usage = new UsageApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CdnApi
        /// </summary>
        public static BitmovinApiBuilder<CdnApi> Builder => new BitmovinApiBuilder<CdnApi>();

        public UsageApi Usage { get; }
    }
}
