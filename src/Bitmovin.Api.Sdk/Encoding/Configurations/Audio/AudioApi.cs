using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Aac;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV1;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV2;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Vorbis;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Opus;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Ac3;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Eac3;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp2;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp3;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio
{
    public class AudioApi
    {
        public AudioApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Aac = new AacApi(apiClientFactory);
            HeAacV1 = new HeAacV1Api(apiClientFactory);
            HeAacV2 = new HeAacV2Api(apiClientFactory);
            Vorbis = new VorbisApi(apiClientFactory);
            Opus = new OpusApi(apiClientFactory);
            Ac3 = new Ac3Api(apiClientFactory);
            Eac3 = new Eac3Api(apiClientFactory);
            Mp2 = new Mp2Api(apiClientFactory);
            Mp3 = new Mp3Api(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AudioApi
        /// </summary>
        public static BitmovinApiBuilder<AudioApi> Builder => new BitmovinApiBuilder<AudioApi>();

        public AacApi Aac { get; private set; }
        public HeAacV1Api HeAacV1 { get; private set; }
        public HeAacV2Api HeAacV2 { get; private set; }
        public VorbisApi Vorbis { get; private set; }
        public OpusApi Opus { get; private set; }
        public Ac3Api Ac3 { get; private set; }
        public Eac3Api Eac3 { get; private set; }
        public Mp2Api Mp2 { get; private set; }
        public Mp3Api Mp3 { get; private set; }

    }
}
