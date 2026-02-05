using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Statistics.Cdn.Usage;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Cdn
{
    /// <summary>
    /// API for CdnApi
    /// </summary>
    public class CdnApi
    {
        /// <summary>
        /// Initializes a new instance of the CdnApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CdnApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Usage = new UsageApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CdnApi
        /// </summary>
        public static BitmovinApiBuilder<CdnApi> Builder => new BitmovinApiBuilder<CdnApi>();

        /// <summary>
        /// Gets the Usage API
        /// </summary>
        public UsageApi Usage { get; }
    }
}
