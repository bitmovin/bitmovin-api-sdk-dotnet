using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Cea;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Dvbsub;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Ttml;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Webvtt;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract
{
    public class ExtractApi
    {
        public ExtractApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Cea = new CeaApi(apiClientFactory);
            Dvbsub = new DvbsubApi(apiClientFactory);
            Ttml = new TtmlApi(apiClientFactory);
            Webvtt = new WebvttApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ExtractApi
        /// </summary>
        public static BitmovinApiBuilder<ExtractApi> Builder => new BitmovinApiBuilder<ExtractApi>();

        public CeaApi Cea { get; private set; }
        public DvbsubApi Dvbsub { get; private set; }
        public TtmlApi Ttml { get; private set; }
        public WebvttApi Webvtt { get; private set; }

    }
}
