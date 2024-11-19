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
    /// LiveStandbyPoolEncodingIngestPoint
    /// </summary>
    public class LiveStandbyPoolEncodingIngestPoint
    {
        /// <summary>
        /// URL to the RTMP/RTMPS endpoint for this live encoding
        /// </summary>
        [JsonProperty(PropertyName = "streamBaseUrl")]
        public string StreamBaseUrl { get; internal set; }

        /// <summary>
        /// Stream key value of this live encoding
        /// </summary>
        [JsonProperty(PropertyName = "streamKey")]
        public string StreamKey { get; internal set; }
    }
}
