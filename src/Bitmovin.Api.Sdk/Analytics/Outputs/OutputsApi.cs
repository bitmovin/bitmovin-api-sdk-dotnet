using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Outputs.Azure;
using Bitmovin.Api.Sdk.Analytics.Outputs.S3RoleBased;
using Bitmovin.Api.Sdk.Analytics.Outputs.GcsServiceAccount;

namespace Bitmovin.Api.Sdk.Analytics.Outputs
{
    /// <summary>
    /// API for OutputsApi
    /// </summary>
    public class OutputsApi
    {
        /// <summary>
        /// Initializes a new instance of the OutputsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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

        /// <summary>
        /// Gets the Azure API
        /// </summary>
        public AzureApi Azure { get; }
        /// <summary>
        /// Gets the S3RoleBased API
        /// </summary>
        public S3RoleBasedApi S3RoleBased { get; }
        /// <summary>
        /// Gets the GcsServiceAccount API
        /// </summary>
        public GcsServiceAccountApi GcsServiceAccount { get; }
    }
}
