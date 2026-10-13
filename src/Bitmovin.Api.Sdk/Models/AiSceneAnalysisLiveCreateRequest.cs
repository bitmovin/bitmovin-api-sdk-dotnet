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
    /// Configuration for a Live Analysis. Each recording and analysis destination references an existing Encoding Output or provides an inline Output definition. Inline Outputs are created synchronously. Within this request, identical complete inline Output definitions, including credentials, are created once and reused across all destinations; destination paths and ACLs do not affect that reuse.
    /// </summary>
    public class AiSceneAnalysisLiveCreateRequest
    {
        /// <summary>
        /// Name of the Analysis
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Key used to publish the RTMP stream. When the Live Analysis is &#x60;RUNNING&#x60;, the Get Live Analysis details response returns the current value in &#x60;ingest.streamKey&#x60;. (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamKey")]
        public string StreamKey { get; set; }

        /// <summary>
        /// Region in which the AI analysis runs. &#x60;EXTERNAL&#x60; is not supported yet.
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public CloudRegion? CloudRegion { get; set; }

        /// <summary>
        /// Encoder release for the backing Live Encoding, using the same values and validation as &#x60;Encoding.encoderVersion&#x60; (for example, &#x60;LATEST&#x60; or a supported release version). Passed unchanged to the Encoding Resource Service. If omitted, the server default is used. Selects the full encoder release; component header overrides remain separate.
        /// </summary>
        [JsonProperty(PropertyName = "encoderVersion")]
        public string EncoderVersion { get; set; }

        /// <summary>
        /// Destinations for the stream recording (required)
        /// </summary>
        [JsonProperty(PropertyName = "recording")]
        public AiSceneAnalysisLiveRecordingRequest Recording { get; set; }

        /// <summary>
        /// Destinations for cumulative AI analysis results (required)
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<AiSceneAnalysisLiveOutput> Outputs { get; set; } = new List<AiSceneAnalysisLiveOutput>();
    }
}
