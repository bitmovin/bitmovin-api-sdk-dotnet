using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.General.ErrorDefinitions;

namespace Bitmovin.Api.Sdk.General
{
    /// <summary>
    /// API for GeneralApi
    /// </summary>
    public class GeneralApi
    {
        /// <summary>
        /// Initializes a new instance of the GeneralApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public GeneralApi(IBitmovinApiClientFactory apiClientFactory)
        {
            ErrorDefinitions = new ErrorDefinitionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of GeneralApi
        /// </summary>
        public static BitmovinApiBuilder<GeneralApi> Builder => new BitmovinApiBuilder<GeneralApi>();

        /// <summary>
        /// Gets the ErrorDefinitions API
        /// </summary>
        public ErrorDefinitionsApi ErrorDefinitions { get; }
    }
}
