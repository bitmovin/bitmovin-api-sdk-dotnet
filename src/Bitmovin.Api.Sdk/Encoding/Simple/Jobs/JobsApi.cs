using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Simple.Jobs.Vod;
using Bitmovin.Api.Sdk.Encoding.Simple.Jobs.Live;

namespace Bitmovin.Api.Sdk.Encoding.Simple.Jobs
{
    public class JobsApi
    {
        public JobsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Vod = new VodApi(apiClientFactory);
            Live = new LiveApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of JobsApi
        /// </summary>
        public static BitmovinApiBuilder<JobsApi> Builder => new BitmovinApiBuilder<JobsApi>();

        public VodApi Vod { get; }
        public LiveApi Live { get; }
    }
}
