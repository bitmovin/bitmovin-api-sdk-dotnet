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
    /// Scheduling
    /// </summary>
    public class Scheduling
    {
        /// <summary>
        /// Specifies the priority of this encoding (0 - 100). Higher numbers mean higher priority. Default is 50.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// List of prewarmed encoder pools. If set, prewarmed encoders from pools with these IDs will be used for the encoding if available. The pool IDs will be tried in the order in which they are passed.
        /// </summary>
        [JsonProperty(PropertyName = "prewarmedEncoderPoolIds")]
        public List<string> PrewarmedEncoderPoolIds { get; set; } = new List<string>();
    }
}
