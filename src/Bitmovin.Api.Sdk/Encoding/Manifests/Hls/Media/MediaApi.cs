using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.CustomTags;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Type;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Video;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Audio;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Subtitles;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Vtt;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.ClosedCaptions;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media
{
    /// <summary>
    /// API for MediaApi
    /// </summary>
    public class MediaApi
    {
        /// <summary>
        /// Initializes a new instance of the MediaApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public MediaApi(IBitmovinApiClientFactory apiClientFactory)
        {
            CustomTags = new CustomTagsApi(apiClientFactory);
            Type = new TypeApi(apiClientFactory);
            Video = new VideoApi(apiClientFactory);
            Audio = new AudioApi(apiClientFactory);
            Subtitles = new SubtitlesApi(apiClientFactory);
            Vtt = new VttApi(apiClientFactory);
            ClosedCaptions = new ClosedCaptionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MediaApi
        /// </summary>
        public static BitmovinApiBuilder<MediaApi> Builder => new BitmovinApiBuilder<MediaApi>();

        /// <summary>
        /// Gets the CustomTags API
        /// </summary>
        public CustomTagsApi CustomTags { get; }
        /// <summary>
        /// Gets the Type API
        /// </summary>
        public TypeApi Type { get; }
        /// <summary>
        /// Gets the Video API
        /// </summary>
        public VideoApi Video { get; }
        /// <summary>
        /// Gets the Audio API
        /// </summary>
        public AudioApi Audio { get; }
        /// <summary>
        /// Gets the Subtitles API
        /// </summary>
        public SubtitlesApi Subtitles { get; }
        /// <summary>
        /// Gets the Vtt API
        /// </summary>
        public VttApi Vtt { get; }
        /// <summary>
        /// Gets the ClosedCaptions API
        /// </summary>
        public ClosedCaptionsApi ClosedCaptions { get; }
    }
}
