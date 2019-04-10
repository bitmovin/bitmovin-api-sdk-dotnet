using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Outputs.S3RoleBased;

namespace Bitmovin.Api.Sdk.Analytics.Outputs
{
    public class OutputsApi
    {
        public OutputsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            S3RoleBased = new S3RoleBasedApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OutputsApi
        /// </summary>
        public static BitmovinApiBuilder<OutputsApi> Builder => new BitmovinApiBuilder<OutputsApi>();

        public S3RoleBasedApi S3RoleBased { get; private set; }

    }
}
