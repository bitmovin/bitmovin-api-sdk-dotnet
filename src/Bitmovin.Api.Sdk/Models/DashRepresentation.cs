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
    /// DashRepresentation
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "typeDiscriminator")]
    [JsonSubtypes.KnownSubType(typeof(DashFmp4DrmRepresentation), "DRM_FMP4")]
    [JsonSubtypes.KnownSubType(typeof(DashFmp4Representation), "FMP4")]
    [JsonSubtypes.KnownSubType(typeof(DashWebmRepresentation), "WEBM")]
    [JsonSubtypes.KnownSubType(typeof(DashCmafRepresentation), "CMAF")]
    [JsonSubtypes.KnownSubType(typeof(DashChunkedTextRepresentation), "CHUNKED_TEXT")]
    [JsonSubtypes.KnownSubType(typeof(DashMp4Representation), "MP4")]
    [JsonSubtypes.KnownSubType(typeof(DashMp4DrmRepresentation), "DRM_MP4")]
    [JsonSubtypes.KnownSubType(typeof(DashProgressiveWebmRepresentation), "PROGRESSIVE_WEBM")]
    [JsonSubtypes.KnownSubType(typeof(DashVttRepresentation), "VTT")]
    [JsonSubtypes.KnownSubType(typeof(SpriteRepresentation), "SPRITE")]
    [JsonSubtypes.KnownSubType(typeof(DashImscRepresentation), "IMSC")]
    [JsonSubtypes.KnownSubType(typeof(ContentProtection), "CONTENT_PROTECTION")]

    public class DashRepresentation : BitmovinResponse
    {
    }
}
