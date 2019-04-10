using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Captions.Webvtt;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Captions.Ttml;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Captions
{
    public class CaptionsApi
    {
        public CaptionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Webvtt = new WebvttApi(apiClientFactory);
            Ttml = new TtmlApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<CaptionsApi> Builder => new BitmovinApiBuilder<CaptionsApi>();

        public WebvttApi Webvtt { get; private set; }
        public TtmlApi Ttml { get; private set; }

    }
}
