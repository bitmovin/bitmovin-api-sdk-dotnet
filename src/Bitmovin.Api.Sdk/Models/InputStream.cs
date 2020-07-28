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
    /// InputStream
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(IngestInputStream), "INGEST")]
    [JsonSubtypes.KnownSubType(typeof(ConcatenationInputStream), "CONCATENATION")]
    [JsonSubtypes.KnownSubType(typeof(TimeBasedTrimmingInputStream), "TRIMMING_TIME_BASED")]
    [JsonSubtypes.KnownSubType(typeof(TimecodeTrackTrimmingInputStream), "TRIMMING_TIME_CODE_TRACK")]
    [JsonSubtypes.KnownSubType(typeof(H264PictureTimingTrimmingInputStream), "TRIMMING_H264_PICTURE_TIMING")]
    [JsonSubtypes.KnownSubType(typeof(AudioMixInputStream), "AUDIO_MIX")]
    [JsonSubtypes.KnownSubType(typeof(DolbyVisionMetadataIngestInputStream), "SIDECAR_DOLBY_VISION_METADATA")]
    [JsonSubtypes.KnownSubType(typeof(Cea608CaptionInputStream), "CAPTION_CEA608")]
    [JsonSubtypes.KnownSubType(typeof(Cea708CaptionInputStream), "CAPTION_CEA708")]
    [JsonSubtypes.KnownSubType(typeof(FileInputStream), "FILE")]
    [JsonSubtypes.KnownSubType(typeof(DvbTeletextInputStream), "DVB_TELETEXT")]
    [JsonSubtypes.KnownSubType(typeof(DolbyAtmosIngestInputStream), "DOLBY_ATMOS")]

    public class InputStream : BitmovinResource
    {
    }
}
