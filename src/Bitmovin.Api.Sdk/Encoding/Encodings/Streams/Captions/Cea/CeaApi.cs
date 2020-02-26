using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea.Scc;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea
{
    public class CeaApi
    {
        public CeaApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Scc = new SccApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CeaApi
        /// </summary>
        public static BitmovinApiBuilder<CeaApi> Builder => new BitmovinApiBuilder<CeaApi>();

        public SccApi Scc { get; }
    }
}
