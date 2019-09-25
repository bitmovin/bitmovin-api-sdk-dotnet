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
    public class MediaApi
    {
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

        public CustomTagsApi CustomTags { get; private set; }
        public TypeApi Type { get; private set; }
        public VideoApi Video { get; private set; }
        public AudioApi Audio { get; private set; }
        public SubtitlesApi Subtitles { get; private set; }
        public VttApi Vtt { get; private set; }
        public ClosedCaptionsApi ClosedCaptions { get; private set; }

    }
}
