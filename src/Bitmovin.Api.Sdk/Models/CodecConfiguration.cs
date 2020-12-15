using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;

using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// CodecConfiguration
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(AacAudioConfiguration), "AAC")]
    [JsonSubtypes.KnownSubType(typeof(DtsPassthroughAudioConfiguration), "DTS_PASSTHROUGH")]
    [JsonSubtypes.KnownSubType(typeof(DvbSubtitleConfiguration), "DVB_SUBTITLE")]
    [JsonSubtypes.KnownSubType(typeof(HeAacV1AudioConfiguration), "HE_AAC_V1")]
    [JsonSubtypes.KnownSubType(typeof(HeAacV2AudioConfiguration), "HE_AAC_V2")]
    [JsonSubtypes.KnownSubType(typeof(H264VideoConfiguration), "H264")]
    [JsonSubtypes.KnownSubType(typeof(H265VideoConfiguration), "H265")]
    [JsonSubtypes.KnownSubType(typeof(Vp9VideoConfiguration), "VP9")]
    [JsonSubtypes.KnownSubType(typeof(Vp8VideoConfiguration), "VP8")]
    [JsonSubtypes.KnownSubType(typeof(Mp2AudioConfiguration), "MP2")]
    [JsonSubtypes.KnownSubType(typeof(Mp3AudioConfiguration), "MP3")]
    [JsonSubtypes.KnownSubType(typeof(Ac3AudioConfiguration), "AC3")]
    [JsonSubtypes.KnownSubType(typeof(Eac3AudioConfiguration), "EAC3")]
    [JsonSubtypes.KnownSubType(typeof(OpusAudioConfiguration), "OPUS")]
    [JsonSubtypes.KnownSubType(typeof(VorbisAudioConfiguration), "VORBIS")]
    [JsonSubtypes.KnownSubType(typeof(MjpegVideoConfiguration), "MJPEG")]
    [JsonSubtypes.KnownSubType(typeof(Av1VideoConfiguration), "AV1")]
    [JsonSubtypes.KnownSubType(typeof(DolbyAtmosAudioConfiguration), "DOLBY_ATMOS")]
    [JsonSubtypes.KnownSubType(typeof(H262VideoConfiguration), "H262")]
    [JsonSubtypes.KnownSubType(typeof(PcmAudioConfiguration), "PCM")]
    [JsonSubtypes.KnownSubType(typeof(WebVttConfiguration), "WEBVTT")]

    public class CodecConfiguration : BitmovinResource
    {
    }
}
