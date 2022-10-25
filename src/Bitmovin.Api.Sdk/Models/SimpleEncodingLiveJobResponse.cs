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
    /// SimpleEncodingLiveJobResponse
    /// </summary>
    public class SimpleEncodingLiveJobResponse
    {
        /// <summary>
        /// The identifier of the Simple Encoding Live Job
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// The current status of the Simple Encoding Live Job
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public SimpleEncodingLiveJobStatus? Status { get; internal set; }

        /// <summary>
        /// The identifier of the encoding that has been created based on the job request. This is only returned once the job execution has been successful and the encoding could be started. 
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; internal set; }

        /// <summary>
        /// The IP address of the encoder for this job request. This is only returned once the job execution has been successful and the encoding could be started. Ingest is expected to be sent to this IP address. 
        /// </summary>
        [JsonProperty(PropertyName = "encoderIp")]
        public string EncoderIp { get; internal set; }

        /// <summary>
        /// Stream key of the live encoder
        /// </summary>
        [JsonProperty(PropertyName = "streamKey")]
        public string StreamKey { get; internal set; }

        /// <summary>
        /// Input
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public SimpleEncodingLiveJobInput Input { get; set; }

        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<SimpleEncodingLiveJobOutput> Outputs { get; set; } = new List<SimpleEncodingLiveJobOutput>();

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

        /// <summary>
        /// The cloud region that will be used for the live encoding
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public SimpleEncodingLiveCloudRegion? CloudRegion { get; set; }

        /// <summary>
        /// The profile that will be used for the live encoding.
        /// </summary>
        [JsonProperty(PropertyName = "encodingProfile")]
        public SimpleEncodingLiveProfile? EncodingProfile { get; set; }
    }
}
