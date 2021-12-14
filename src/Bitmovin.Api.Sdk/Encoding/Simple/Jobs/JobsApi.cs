using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Simple.Jobs.Vod;

namespace Bitmovin.Api.Sdk.Encoding.Simple.Jobs
{
    public class JobsApi
    {
        public JobsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Vod = new VodApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of JobsApi
        /// </summary>
        public static BitmovinApiBuilder<JobsApi> Builder => new BitmovinApiBuilder<JobsApi>();

        public VodApi Vod { get; }
    }
}
