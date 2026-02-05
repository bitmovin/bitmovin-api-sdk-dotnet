using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.DvbSubtitle;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.Webvtt;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.Imsc;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles
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
            Webvtt = new WebvttApi(apiClientFactory);
            Imsc = new ImscApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SubtitlesApi
        /// </summary>
        public static BitmovinApiBuilder<SubtitlesApi> Builder => new BitmovinApiBuilder<SubtitlesApi>();

        /// <summary>
        /// Gets the DvbSubtitle API
        /// </summary>
        public DvbSubtitleApi DvbSubtitle { get; }
        /// <summary>
        /// Gets the Webvtt API
        /// </summary>
        public WebvttApi Webvtt { get; }
        /// <summary>
        /// Gets the Imsc API
        /// </summary>
        public ImscApi Imsc { get; }
    }
}
