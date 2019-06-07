using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.General.ErrorDefinitions;

namespace Bitmovin.Api.Sdk.General
{
    public class GeneralApi
    {
        public GeneralApi(IBitmovinApiClientFactory apiClientFactory)
        {
            ErrorDefinitions = new ErrorDefinitionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of GeneralApi
        /// </summary>
        public static BitmovinApiBuilder<GeneralApi> Builder => new BitmovinApiBuilder<GeneralApi>();

        public ErrorDefinitionsApi ErrorDefinitions { get; private set; }

    }
}
