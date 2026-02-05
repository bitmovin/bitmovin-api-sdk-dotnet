using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Subtitles.DvbSubtitle;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Subtitles
{
    /// <summary>
    /// API for SubtitlesApi
    /// </summary>
    public class SubtitlesApi
    {
        /// <summary>
        /// Initializes a new instance of the SubtitlesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SubtitlesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            DvbSubtitle = new DvbSubtitleApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SubtitlesApi
        /// </summary>
        public static BitmovinApiBuilder<SubtitlesApi> Builder => new BitmovinApiBuilder<SubtitlesApi>();

        /// <summary>
        /// Gets the DvbSubtitle API
        /// </summary>
        public DvbSubtitleApi DvbSubtitle { get; }
    }
}
