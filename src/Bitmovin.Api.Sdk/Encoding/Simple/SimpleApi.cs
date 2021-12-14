using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Simple.Jobs;

namespace Bitmovin.Api.Sdk.Encoding.Simple
{
    public class SimpleApi
    {
        public SimpleApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Jobs = new JobsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SimpleApi
        /// </summary>
        public static BitmovinApiBuilder<SimpleApi> Builder => new BitmovinApiBuilder<SimpleApi>();

        public JobsApi Jobs { get; }
    }
}
