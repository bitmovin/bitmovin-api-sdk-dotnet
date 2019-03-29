using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Aws;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure
{
    public class InfrastructureApi
    {
        public InfrastructureApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Kubernetes = new KubernetesApi(apiClientFactory);
            Aws = new AwsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InfrastructureApi
        /// </summary>
        public static BitmovinApiBuilder<InfrastructureApi> Builder => new BitmovinApiBuilder<InfrastructureApi>();

        public KubernetesApi Kubernetes { get; private set; }
        public AwsApi Aws { get; private set; }

    }
}
