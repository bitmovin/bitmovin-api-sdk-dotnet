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
    /// Drm
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(WidevineDrm), "WIDEVINE")]
    [JsonSubtypes.KnownSubType(typeof(PlayReadyDrm), "PLAYREADY")]
    [JsonSubtypes.KnownSubType(typeof(PrimeTimeDrm), "PRIMETIME")]
    [JsonSubtypes.KnownSubType(typeof(FairPlayDrm), "FAIRPLAY")]
    [JsonSubtypes.KnownSubType(typeof(MarlinDrm), "MARLIN")]
    [JsonSubtypes.KnownSubType(typeof(ClearKeyDrm), "CLEARKEY")]
    [JsonSubtypes.KnownSubType(typeof(AesEncryptionDrm), "AES")]
    [JsonSubtypes.KnownSubType(typeof(CencDrm), "CENC")]
    [JsonSubtypes.KnownSubType(typeof(SpekeDrm), "SPEKE")]

    public class Drm : BitmovinResource
    {
        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; } = new List<EncodingOutput>();
    }
}
