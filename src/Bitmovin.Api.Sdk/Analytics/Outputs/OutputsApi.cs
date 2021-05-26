using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Outputs.Azure;
using Bitmovin.Api.Sdk.Analytics.Outputs.S3RoleBased;
using Bitmovin.Api.Sdk.Analytics.Outputs.GcsServiceAccount;

namespace Bitmovin.Api.Sdk.Analytics.Outputs
{
    public class OutputsApi
    {
        public OutputsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Azure = new AzureApi(apiClientFactory);
            S3RoleBased = new S3RoleBasedApi(apiClientFactory);
            GcsServiceAccount = new GcsServiceAccountApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OutputsApi
        /// </summary>
        public static BitmovinApiBuilder<OutputsApi> Builder => new BitmovinApiBuilder<OutputsApi>();

        public AzureApi Azure { get; }
        public S3RoleBasedApi S3RoleBased { get; }
        public GcsServiceAccountApi GcsServiceAccount { get; }
    }
}
