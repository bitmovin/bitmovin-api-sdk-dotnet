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
    /// <summary>
    /// API for InfrastructureApi
    /// </summary>
    public class InfrastructureApi
    {
        /// <summary>
        /// Initializes a new instance of the InfrastructureApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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

        /// <summary>
        /// Gets the Aws API
        /// </summary>
        public AwsApi Aws { get; }
        /// <summary>
        /// Gets the StaticIps API
        /// </summary>
        public StaticIpsApi StaticIps { get; }
        /// <summary>
        /// Gets the Azure API
        /// </summary>
        public AzureApi Azure { get; }
        /// <summary>
        /// Gets the Gce API
        /// </summary>
        public GceApi Gce { get; }
        /// <summary>
        /// Gets the Akamai API
        /// </summary>
        public AkamaiApi Akamai { get; }
        /// <summary>
        /// Gets the Oci API
        /// </summary>
        public OciApi Oci { get; }
        /// <summary>
        /// Gets the PrewarmedEncoderPools API
        /// </summary>
        public PrewarmedEncoderPoolsApi PrewarmedEncoderPools { get; }
    }
}
