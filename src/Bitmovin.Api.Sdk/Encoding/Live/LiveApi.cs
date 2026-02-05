using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Live.StreamKeys;
using Bitmovin.Api.Sdk.Encoding.Live.StandbyPools;

namespace Bitmovin.Api.Sdk.Encoding.Live
{
    /// <summary>
    /// API for LiveApi
    /// </summary>
    public class LiveApi
    {
        /// <summary>
        /// Initializes a new instance of the LiveApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public LiveApi(IBitmovinApiClientFactory apiClientFactory)
        {
            StreamKeys = new StreamKeysApi(apiClientFactory);
            StandbyPools = new StandbyPoolsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveApi
        /// </summary>
        public static BitmovinApiBuilder<LiveApi> Builder => new BitmovinApiBuilder<LiveApi>();

        /// <summary>
        /// Gets the StreamKeys API
        /// </summary>
        public StreamKeysApi StreamKeys { get; }
        /// <summary>
        /// Gets the StandbyPools API
        /// </summary>
        public StandbyPoolsApi StandbyPools { get; }
    }
}
