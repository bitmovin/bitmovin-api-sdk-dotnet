using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Aws;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Azure;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Gce;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure
{
    public class InfrastructureApi
    {
        public InfrastructureApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Kubernetes = new KubernetesApi(apiClientFactory);
            Aws = new AwsApi(apiClientFactory);
            Azure = new AzureApi(apiClientFactory);
            Gce = new GceApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InfrastructureApi
        /// </summary>
        public static BitmovinApiBuilder<InfrastructureApi> Builder => new BitmovinApiBuilder<InfrastructureApi>();

        public KubernetesApi Kubernetes { get; }
        public AwsApi Aws { get; }
        public AzureApi Azure { get; }
        public GceApi Gce { get; }
    }
}
