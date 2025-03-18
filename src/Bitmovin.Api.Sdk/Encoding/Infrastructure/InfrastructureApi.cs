using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Aws;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.StaticIps;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Azure;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Gce;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Akamai;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Oci;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.PrewarmedEncoderPools;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure
{
    public class InfrastructureApi
    {
        public InfrastructureApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Aws = new AwsApi(apiClientFactory);
            StaticIps = new StaticIpsApi(apiClientFactory);
            Azure = new AzureApi(apiClientFactory);
            Gce = new GceApi(apiClientFactory);
            Akamai = new AkamaiApi(apiClientFactory);
            Oci = new OciApi(apiClientFactory);
            PrewarmedEncoderPools = new PrewarmedEncoderPoolsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InfrastructureApi
        /// </summary>
        public static BitmovinApiBuilder<InfrastructureApi> Builder => new BitmovinApiBuilder<InfrastructureApi>();

        public AwsApi Aws { get; }
        public StaticIpsApi StaticIps { get; }
        public AzureApi Azure { get; }
        public GceApi Gce { get; }
        public AkamaiApi Akamai { get; }
        public OciApi Oci { get; }
        public PrewarmedEncoderPoolsApi PrewarmedEncoderPools { get; }
    }
}
