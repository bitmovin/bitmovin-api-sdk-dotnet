using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Account.Information;
using Bitmovin.Api.Sdk.Account.Login;
using Bitmovin.Api.Sdk.Account.Limits;
using Bitmovin.Api.Sdk.Account.ApiKeys;
using Bitmovin.Api.Sdk.Account.Organizations;

namespace Bitmovin.Api.Sdk.Account
{
    public class AccountApi
    {
        public AccountApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Information = new InformationApi(apiClientFactory);
            Login = new LoginApi(apiClientFactory);
            Limits = new LimitsApi(apiClientFactory);
            ApiKeys = new ApiKeysApi(apiClientFactory);
            Organizations = new OrganizationsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AccountApi
        /// </summary>
        public static BitmovinApiBuilder<AccountApi> Builder => new BitmovinApiBuilder<AccountApi>();

        public InformationApi Information { get; private set; }
        public LoginApi Login { get; private set; }
        public LimitsApi Limits { get; private set; }
        public ApiKeysApi ApiKeys { get; private set; }
        public OrganizationsApi Organizations { get; private set; }

    }
}
