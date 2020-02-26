using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Scc;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions
{
    public class CaptionsApi
    {
        public CaptionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Scc = new SccApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<CaptionsApi> Builder => new BitmovinApiBuilder<CaptionsApi>();

        public SccApi Scc { get; }
    }
}
