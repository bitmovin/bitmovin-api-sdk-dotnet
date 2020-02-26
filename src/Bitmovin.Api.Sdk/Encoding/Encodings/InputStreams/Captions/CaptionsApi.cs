using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Captions.Cea608;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Captions.Cea708;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Captions
{
    public class CaptionsApi
    {
        public CaptionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Cea608 = new Cea608Api(apiClientFactory);
            Cea708 = new Cea708Api(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<CaptionsApi> Builder => new BitmovinApiBuilder<CaptionsApi>();

        public Cea608Api Cea608 { get; }
        public Cea708Api Cea708 { get; }
    }
}
