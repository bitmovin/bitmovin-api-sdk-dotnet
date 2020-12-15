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
    /// Encoding
    /// </summary>
    public class Encoding : BitmovinResource
    {
        /// <summary>
        /// Type of the encoding
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public EncodingType? Type { get; internal set; }

        /// <summary>
        /// Timestamp when the encoding was started, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// Timestamp when the encoding status changed to \&quot;QUEUED\&quot;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "queuedAt")]
        public DateTime? QueuedAt { get; internal set; }

        /// <summary>
        /// Timestamp when the encoding status changed to \&quot;RUNNING\&quot;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "runningAt")]
        public DateTime? RunningAt { get; internal set; }

        /// <summary>
        /// Timestamp when the encoding status changed to &#39;FINISHED&#39;, &#39;ERROR&#39;, &#39;CANCELED&#39;, or &#39;TRANSFER_ERROR&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ  Note that this timestamp might be inaccurate for encodings which ran prior to the [1.50.0 REST API release](https://bitmovin.com/docs/encoding/changelogs/rest). 
        /// </summary>
        [JsonProperty(PropertyName = "finishedAt")]
        public DateTime? FinishedAt { get; internal set; }

        /// <summary>
        /// Timestamp when the encoding status changed to &#39;ERROR&#39;, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ  Note that this timestamp is deprecated and is equivalent to finishedAt in case of an &#39;ERROR&#39;. 
        /// </summary>
        [JsonProperty(PropertyName = "errorAt")]
        public DateTime? ErrorAt { get; internal set; }

        /// <summary>
        /// Progress of the encoding in percent
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int? Progress { get; internal set; }

        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public CloudRegion? CloudRegion { get; set; }

        /// <summary>
        /// Specify a list of regions which are used in case the preferred region is down. Currently there are several restrictions. - The region has to be specific or AUTO - The region has to be for the same cloud provider as the default one - You can only configure at most 3 fallback regions 
        /// </summary>
        [JsonProperty(PropertyName = "fallbackCloudRegions")]
        public List<CloudRegion> FallbackCloudRegions { get; set; } = new List<CloudRegion>();

        /// <summary>
        /// Version of the encoder
        /// </summary>
        [JsonProperty(PropertyName = "encoderVersion")]
        public string EncoderVersion { get; set; }

        /// <summary>
        /// Define an external infrastructure to run the encoding on. Note If you set this value, the &#x60;cloudRegion&#x60; must be &#39;EXTERNAL&#39;.
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureId")]
        public string InfrastructureId { get; set; }

        /// <summary>
        /// Infrastructure
        /// </summary>
        [JsonProperty(PropertyName = "infrastructure")]
        public InfrastructureSettings Infrastructure { get; set; }

        /// <summary>
        /// Specify an ID of a Static IP infrastructure resource this encoding should use. A Static IP cannot be used by multiple encodings at once. The encoding will go to an error state if the Static IP is already in use. This is currently only supported for live encodings.
        /// </summary>
        [JsonProperty(PropertyName = "staticIpId")]
        public string StaticIpId { get; set; }

        /// <summary>
        /// After the encoding has been started, this will contain the encoder version that was actually used. Especially useful when starting an encoding with a version tag like STABLE or BETA.
        /// </summary>
        [JsonProperty(PropertyName = "selectedEncoderVersion")]
        public string SelectedEncoderVersion { get; internal set; }

        /// <summary>
        /// After the encoding has been started, this will contain the encoding mode that was actually used. Especially useful when starting an encoding with encoding mode STANDARD.
        /// </summary>
        [JsonProperty(PropertyName = "selectedEncodingMode")]
        public EncodingMode? SelectedEncodingMode { get; internal set; }

        /// <summary>
        /// After the encoding has been started, this will contain the cloud region that was actually used. This will differ from cloudRegion if cloudRegion was set to an unspecific region (e.g. &#39;AUTO&#39;)
        /// </summary>
        [JsonProperty(PropertyName = "selectedCloudRegion")]
        public CloudRegion? SelectedCloudRegion { get; internal set; }

        /// <summary>
        /// The current status of the encoding.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Status? Status { get; internal set; }

        /// <summary>
        /// You may pass a list of groups associated with this encoding. This will enable you to group results in the statistics resource
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public List<string> Labels { get; set; } = new List<string>();
    }
}
