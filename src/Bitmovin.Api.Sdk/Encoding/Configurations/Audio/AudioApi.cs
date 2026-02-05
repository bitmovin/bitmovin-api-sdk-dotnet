using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Aac;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DtsPassthrough;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Dts;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Dtsx;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DolbyAtmos;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV1;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV2;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Passthrough;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Vorbis;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Opus;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Pcm;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Ac3;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DolbyDigital;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DolbyDigitalPlus;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Eac3;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp2;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp3;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio
{
    /// <summary>
    /// API for AudioApi
    /// </summary>
    public class AudioApi
    {
        /// <summary>
        /// Initializes a new instance of the AudioApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AudioApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Aac = new AacApi(apiClientFactory);
            DtsPassthrough = new DtsPassthroughApi(apiClientFactory);
            Dts = new DtsApi(apiClientFactory);
            Dtsx = new DtsxApi(apiClientFactory);
            DolbyAtmos = new DolbyAtmosApi(apiClientFactory);
            HeAacV1 = new HeAacV1Api(apiClientFactory);
            HeAacV2 = new HeAacV2Api(apiClientFactory);
            Passthrough = new PassthroughApi(apiClientFactory);
            Vorbis = new VorbisApi(apiClientFactory);
            Opus = new OpusApi(apiClientFactory);
            Pcm = new PcmApi(apiClientFactory);
            Ac3 = new Ac3Api(apiClientFactory);
            DolbyDigital = new DolbyDigitalApi(apiClientFactory);
            DolbyDigitalPlus = new DolbyDigitalPlusApi(apiClientFactory);
            Eac3 = new Eac3Api(apiClientFactory);
            Mp2 = new Mp2Api(apiClientFactory);
            Mp3 = new Mp3Api(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AudioApi
        /// </summary>
        public static BitmovinApiBuilder<AudioApi> Builder => new BitmovinApiBuilder<AudioApi>();

        /// <summary>
        /// Gets the Aac API
        /// </summary>
        public AacApi Aac { get; }
        /// <summary>
        /// Gets the DtsPassthrough API
        /// </summary>
        public DtsPassthroughApi DtsPassthrough { get; }
        /// <summary>
        /// Gets the Dts API
        /// </summary>
        public DtsApi Dts { get; }
        /// <summary>
        /// Gets the Dtsx API
        /// </summary>
        public DtsxApi Dtsx { get; }
        /// <summary>
        /// Gets the DolbyAtmos API
        /// </summary>
        public DolbyAtmosApi DolbyAtmos { get; }
        /// <summary>
        /// Gets the HeAacV1 API
        /// </summary>
        public HeAacV1Api HeAacV1 { get; }
        /// <summary>
        /// Gets the HeAacV2 API
        /// </summary>
        public HeAacV2Api HeAacV2 { get; }
        /// <summary>
        /// Gets the Passthrough API
        /// </summary>
        public PassthroughApi Passthrough { get; }
        /// <summary>
        /// Gets the Vorbis API
        /// </summary>
        public VorbisApi Vorbis { get; }
        /// <summary>
        /// Gets the Opus API
        /// </summary>
        public OpusApi Opus { get; }
        /// <summary>
        /// Gets the Pcm API
        /// </summary>
        public PcmApi Pcm { get; }
        /// <summary>
        /// Gets the Ac3 API
        /// </summary>
        public Ac3Api Ac3 { get; }
        /// <summary>
        /// Gets the DolbyDigital API
        /// </summary>
        public DolbyDigitalApi DolbyDigital { get; }
        /// <summary>
        /// Gets the DolbyDigitalPlus API
        /// </summary>
        public DolbyDigitalPlusApi DolbyDigitalPlus { get; }
        /// <summary>
        /// Gets the Eac3 API
        /// </summary>
        public Eac3Api Eac3 { get; }
        /// <summary>
        /// Gets the Mp2 API
        /// </summary>
        public Mp2Api Mp2 { get; }
        /// <summary>
        /// Gets the Mp3 API
        /// </summary>
        public Mp3Api Mp3 { get; }
    }
}
