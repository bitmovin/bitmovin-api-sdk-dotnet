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
    /// KantarWatermark
    /// </summary>
    public class KantarWatermark : BitmovinResponse
    {
        /// <summary>
        /// Username used to authenticate with the Kantar watermarking service. (required)
        /// </summary>
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        /// <summary>
        /// Password associated with the provided login for authentication. (required)
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Identifier of the Kantar license to be used when processing the audio watermark. (required)
        /// </summary>
        [JsonProperty(PropertyName = "licenseId")]
        public int? LicenseId { get; set; }

        /// <summary>
        /// Name of the distribution channel associated with the audio content being watermarked. (required)
        /// </summary>
        [JsonProperty(PropertyName = "channelName")]
        public string ChannelName { get; set; }

        /// <summary>
        /// Unique reference or identifier for the audio content that will be processed. (required)
        /// </summary>
        [JsonProperty(PropertyName = "contentReference")]
        public string ContentReference { get; set; }

        /// <summary>
        /// URL of the Kantar server endpoint used to apply or validate the audio watermark. (required)
        /// </summary>
        [JsonProperty(PropertyName = "serverUrl")]
        public string ServerUrl { get; set; }

        /// <summary>
        /// The outputs where the processing report should be delivered. (required)
        /// </summary>
        [JsonProperty(PropertyName = "reportOutputs")]
        public List<EncodingOutput> ReportOutputs { get; set; } = new List<EncodingOutput>();
    }
}
