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
    /// SimpleEncodingVodJobOutput
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(SimpleEncodingVodJobUrlOutput), "URL")]
    [JsonSubtypes.KnownSubType(typeof(SimpleEncodingVodJobCdnOutput), "CDN")]

    public class SimpleEncodingVodJobOutput
    {
        /// <summary>
        /// List of artifacts created by the encoding job. Artifacts are files essential for playback of the generated content, e.g. manifests. 
        /// </summary>
        [JsonProperty(PropertyName = "artifacts")]
        public List<SimpleEncodingVodJobOutputArtifact> Artifacts { get; internal set; } = new List<SimpleEncodingVodJobOutputArtifact>();
    }
}
