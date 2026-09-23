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
    /// AiSceneAnalysisLiveResponse
    /// </summary>
    public class AiSceneAnalysisLiveResponse
    {
        /// <summary>
        /// ID of the Live Analysis resource (required)
        /// </summary>
        [JsonProperty(PropertyName = "analysisId")]
        public string AnalysisId { get; internal set; }

        /// <summary>
        /// ID of the Encoding associated with the Analysis (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; internal set; }

        /// <summary>
        /// Name of the Analysis
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; internal set; }

        /// <summary>
        /// Current lifecycle state of the Live Analysis (required)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public AiSceneAnalysisLiveStatus? Status { get; internal set; }

        /// <summary>
        /// Resolved output configuration for the stream recording (required)
        /// </summary>
        [JsonProperty(PropertyName = "recording")]
        public AiSceneAnalysisLiveRecording Recording { get; internal set; }

        /// <summary>
        /// Resolved Encoding Output ID references for cumulative AI analysis results (required)
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; internal set; } = new List<EncodingOutput>();

        /// <summary>
        /// Current RTMP ingest details. Present only in the Get Live Analysis details response while the Live Analysis is &#x60;RUNNING&#x60;.
        /// </summary>
        [JsonProperty(PropertyName = "ingest")]
        public LiveEncoding Ingest { get; internal set; }

        /// <summary>
        /// Failure details. Present only when the status is &#x60;ERROR&#x60; or &#x60;TRANSFER_ERROR&#x60;.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public AiSceneAnalysisLiveError Error { get; internal set; }

        /// <summary>
        /// Creation timestamp, returned as UTC in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ (required)
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; internal set; }
    }
}
