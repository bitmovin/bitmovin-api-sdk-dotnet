using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Vtt;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Sidecar;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Fmp4;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Cmaf;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Mp4;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Webm;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations
{
    public class RepresentationsApi
    {
        public RepresentationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Vtt = new VttApi(apiClientFactory);
            Sidecar = new SidecarApi(apiClientFactory);
            Fmp4 = new Fmp4Api(apiClientFactory);
            Cmaf = new CmafApi(apiClientFactory);
            Mp4 = new Mp4Api(apiClientFactory);
            Webm = new WebmApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of RepresentationsApi
        /// </summary>
        public static BitmovinApiBuilder<RepresentationsApi> Builder => new BitmovinApiBuilder<RepresentationsApi>();

        public VttApi Vtt { get; private set; }
        public SidecarApi Sidecar { get; private set; }
        public Fmp4Api Fmp4 { get; private set; }
        public CmafApi Cmaf { get; private set; }
        public Mp4Api Mp4 { get; private set; }
        public WebmApi Webm { get; private set; }

    }
}
