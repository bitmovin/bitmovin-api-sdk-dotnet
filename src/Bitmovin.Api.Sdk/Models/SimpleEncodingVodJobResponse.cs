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
    /// SimpleEncodingVodJobResponse
    /// </summary>
    public class SimpleEncodingVodJobResponse
    {
        /// <summary>
        /// The identifier of the Simple Encoding VOD Job
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// The current status of the Simple Encoding VOD Job
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public SimpleEncodingVodJobStatus? Status { get; internal set; }

        /// <summary>
        /// The template that has been used for the encoding.
        /// </summary>
        [JsonProperty(PropertyName = "encodingTemplate")]
        public EncodingTemplate? EncodingTemplate { get; set; }

        /// <summary>
        /// The identifier of the encoding that has been created based on the job request. This is only returned once the job execution has been successful and the encoding could be started. 
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; internal set; }

        /// <summary>
        /// Inputs
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public List<SimpleEncodingVodJobInput> Inputs { get; set; } = new List<SimpleEncodingVodJobInput>();

        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<SimpleEncodingVodJobOutput> Outputs { get; set; } = new List<SimpleEncodingVodJobOutput>();

        /// <summary>
        /// Options to customize the Simple Encoding Job
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public SimpleEncodingVodJobOptions Options { get; set; }

        /// <summary>
        /// Describes all the errors in cases the status of the job is &#39;error&#39;. 
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public List<SimpleEncodingVodJobErrors> Errors { get; set; } = new List<SimpleEncodingVodJobErrors>();

        /// <summary>
        /// Creation timestamp, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Modified timestamp, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ. The job is updated for example when the status changes
        /// </summary>
        [JsonProperty(PropertyName = "modifiedAt")]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// This property will be used for naming the encoding and the manifests.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
