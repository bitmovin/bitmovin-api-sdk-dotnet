using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Account.Information;
using Bitmovin.Api.Sdk.Account.ApiKeys;
using Bitmovin.Api.Sdk.Account.Organizations;

namespace Bitmovin.Api.Sdk.Account
{
    /// <summary>
    /// API for AccountApi
    /// </summary>
    public class AccountApi
    {
        /// <summary>
        /// Initializes a new instance of the AccountApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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

        /// <summary>
        /// Gets the Information API
        /// </summary>
        public InformationApi Information { get; }
        /// <summary>
        /// Gets the ApiKeys API
        /// </summary>
        public ApiKeysApi ApiKeys { get; }
        /// <summary>
        /// Gets the Organizations API
        /// </summary>
        public OrganizationsApi Organizations { get; }
    }
}
