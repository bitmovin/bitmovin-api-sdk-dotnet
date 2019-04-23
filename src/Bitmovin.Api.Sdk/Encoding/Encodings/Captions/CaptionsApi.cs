using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Scc;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions
{
    public class CaptionsApi
    {
        public CaptionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Extract = new ExtractApi(apiClientFactory);
            Scc = new SccApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<CaptionsApi> Builder => new BitmovinApiBuilder<CaptionsApi>();

        public ExtractApi Extract { get; private set; }
        public SccApi Scc { get; private set; }

    }
}
