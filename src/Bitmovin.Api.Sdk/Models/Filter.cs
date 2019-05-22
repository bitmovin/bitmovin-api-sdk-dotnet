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
    /// Filter
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CropFilter), "CROP")]
    [JsonSubtypes.KnownSubType(typeof(WatermarkFilter), "WATERMARK")]
    [JsonSubtypes.KnownSubType(typeof(EnhancedWatermarkFilter), "ENHANCED_WATERMARK")]
    [JsonSubtypes.KnownSubType(typeof(RotateFilter), "ROTATE")]
    [JsonSubtypes.KnownSubType(typeof(DeinterlaceFilter), "DEINTERLACE")]
    [JsonSubtypes.KnownSubType(typeof(AudioMixFilter), "AUDIO_MIX")]
    [JsonSubtypes.KnownSubType(typeof(DenoiseHqdn3dFilter), "DENOISE_HQDN3D")]
    [JsonSubtypes.KnownSubType(typeof(TextFilter), "TEXT")]
    [JsonSubtypes.KnownSubType(typeof(UnsharpFilter), "UNSHARP")]
    [JsonSubtypes.KnownSubType(typeof(ScaleFilter), "SCALE")]
    [JsonSubtypes.KnownSubType(typeof(InterlaceFilter), "INTERLACE")]
    [JsonSubtypes.KnownSubType(typeof(AudioVolumeFilter), "AUDIO_VOLUME")]
    [JsonSubtypes.KnownSubType(typeof(EbuR128SinglePassFilter), "EBU_R128_SINGLE_PASS")]

    public class Filter : BitmovinResource
    {
    }

}
