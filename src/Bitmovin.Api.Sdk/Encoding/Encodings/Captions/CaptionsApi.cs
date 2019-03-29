using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Cea;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Webvtt;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Ttml;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Scc;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions
{
    public class CaptionsApi
    {
        public CaptionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Cea = new CeaApi(apiClientFactory);
            Webvtt = new WebvttApi(apiClientFactory);
            Ttml = new TtmlApi(apiClientFactory);
            Scc = new SccApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<CaptionsApi> Builder => new BitmovinApiBuilder<CaptionsApi>();

        public CeaApi Cea { get; private set; }
        public WebvttApi Webvtt { get; private set; }
        public TtmlApi Ttml { get; private set; }
        public SccApi Scc { get; private set; }

    }
}
