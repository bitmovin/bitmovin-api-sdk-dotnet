using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Account.Information;
using Bitmovin.Api.Sdk.Account.ApiKeys;
using Bitmovin.Api.Sdk.Account.Organizations;

namespace Bitmovin.Api.Sdk.Account
{
    public class AccountApi
    {
        public AccountApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Information = new InformationApi(apiClientFactory);
            ApiKeys = new ApiKeysApi(apiClientFactory);
            Organizations = new OrganizationsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AccountApi
        /// </summary>
        public static BitmovinApiBuilder<AccountApi> Builder => new BitmovinApiBuilder<AccountApi>();

        public InformationApi Information { get; }
        public ApiKeysApi ApiKeys { get; }
        public OrganizationsApi Organizations { get; }
    }
}
