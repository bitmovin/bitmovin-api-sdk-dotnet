using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Vtt;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Sprite;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Fmp4;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.ChunkedText;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Cmaf;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Mp4;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Webm;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.ProgressiveWebm;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations
{
    public class RepresentationsApi
    {
        public RepresentationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Vtt = new VttApi(apiClientFactory);
            Sprite = new SpriteApi(apiClientFactory);
            Fmp4 = new Fmp4Api(apiClientFactory);
            ChunkedText = new ChunkedTextApi(apiClientFactory);
            Cmaf = new CmafApi(apiClientFactory);
            Mp4 = new Mp4Api(apiClientFactory);
            Webm = new WebmApi(apiClientFactory);
            ProgressiveWebm = new ProgressiveWebmApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of RepresentationsApi
        /// </summary>
        public static BitmovinApiBuilder<RepresentationsApi> Builder => new BitmovinApiBuilder<RepresentationsApi>();

        public VttApi Vtt { get; }
        public SpriteApi Sprite { get; }
        public Fmp4Api Fmp4 { get; }
        public ChunkedTextApi ChunkedText { get; }
        public CmafApi Cmaf { get; }
        public Mp4Api Mp4 { get; }
        public WebmApi Webm { get; }
        public ProgressiveWebmApi ProgressiveWebm { get; }
    }
}
