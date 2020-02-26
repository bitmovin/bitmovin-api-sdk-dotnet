using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Audio;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Video;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Subtitle;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Contentprotection;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets
{
    public class AdaptationsetsApi
    {
        public AdaptationsetsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Audio = new AudioApi(apiClientFactory);
            Video = new VideoApi(apiClientFactory);
            Subtitle = new SubtitleApi(apiClientFactory);
            Representations = new RepresentationsApi(apiClientFactory);
            Contentprotection = new ContentprotectionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AdaptationsetsApi
        /// </summary>
        public static BitmovinApiBuilder<AdaptationsetsApi> Builder => new BitmovinApiBuilder<AdaptationsetsApi>();

        public AudioApi Audio { get; }
        public VideoApi Video { get; }
        public SubtitleApi Subtitle { get; }
        public RepresentationsApi Representations { get; }
        public ContentprotectionApi Contentprotection { get; }
    }
}
