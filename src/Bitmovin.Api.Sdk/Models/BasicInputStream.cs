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
    /// BasicInputStream
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(IngestInputStream), "INGEST")]
    [JsonSubtypes.KnownSubType(typeof(ConcatenationInputStream), "CONCATENATION")]
    [JsonSubtypes.KnownSubType(typeof(TimeBasedTrimmingInputStream), "TRIMMING_TIME_BASED")]
    [JsonSubtypes.KnownSubType(typeof(TimecodeTrackTrimmingInputStream), "TRIMMING_TIME_CODE_TRACK")]
    [JsonSubtypes.KnownSubType(typeof(H264PictureTimingTrimmingInputStream), "TRIMMING_H264_PICTURE_TIMING")]
    [JsonSubtypes.KnownSubType(typeof(AudioMixInputStream), "AUDIO_MIX")]

    public class BasicInputStream : BitmovinResource
    {
    }

}
