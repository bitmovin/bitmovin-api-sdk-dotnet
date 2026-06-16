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
    /// LiveEncodingHeartbeatUrlResponse
    /// </summary>
    public class LiveEncodingHeartbeatUrlResponse
    {
        /// <summary>
        /// Presigned S3 URL to download the final heartbeat JSON of the live encoding. Valid for 10 minutes. (required)
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; internal set; }
    }
}
