using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.DvbSubtitle;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.Webvtt;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.Imsc;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles
{
    public class SubtitlesApi
    {
        public SubtitlesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            DvbSubtitle = new DvbSubtitleApi(apiClientFactory);
            Webvtt = new WebvttApi(apiClientFactory);
            Imsc = new ImscApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SubtitlesApi
        /// </summary>
        public static BitmovinApiBuilder<SubtitlesApi> Builder => new BitmovinApiBuilder<SubtitlesApi>();

        public DvbSubtitleApi DvbSubtitle { get; }
        public WebvttApi Webvtt { get; }
        public ImscApi Imsc { get; }
    }
}
