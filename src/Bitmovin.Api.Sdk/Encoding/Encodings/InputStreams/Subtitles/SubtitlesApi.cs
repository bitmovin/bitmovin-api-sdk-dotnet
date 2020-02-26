using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Subtitles.DvbTeletext;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Subtitles
{
    public class SubtitlesApi
    {
        public SubtitlesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            DvbTeletext = new DvbTeletextApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SubtitlesApi
        /// </summary>
        public static BitmovinApiBuilder<SubtitlesApi> Builder => new BitmovinApiBuilder<SubtitlesApi>();

        public DvbTeletextApi DvbTeletext { get; }
    }
}
