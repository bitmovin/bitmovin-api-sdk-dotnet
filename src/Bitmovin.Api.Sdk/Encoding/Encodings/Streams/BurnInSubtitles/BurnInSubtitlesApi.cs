using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Dvbsub;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Srt;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles
{
    public class BurnInSubtitlesApi
    {
        public BurnInSubtitlesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Dvbsub = new DvbsubApi(apiClientFactory);
            Srt = new SrtApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of BurnInSubtitlesApi
        /// </summary>
        public static BitmovinApiBuilder<BurnInSubtitlesApi> Builder => new BitmovinApiBuilder<BurnInSubtitlesApi>();

        public DvbsubApi Dvbsub { get; }
        public SrtApi Srt { get; }
    }
}
