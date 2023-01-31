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
    /// CheckOutputPermissionsResponse
    /// </summary>
    public class CheckOutputPermissionsResponse
    {
        /// <summary>
        /// Id of the output for which permissions were checked
        /// </summary>
        [JsonProperty(PropertyName = "outputId")]
        public string OutputId { get; internal set; }

        /// <summary>
        /// The type of the output for which permissions were checked
        /// </summary>
        [JsonProperty(PropertyName = "outputType")]
        public OutputType? OutputType { get; internal set; }

        /// <summary>
        /// The path on the storage for which permissions were checked. In AWS S3 terminology, this corresponds to a \&quot;prefix\&quot;. An empty string corresponds to the root directory.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; internal set; }

        /// <summary>
        /// Indicates if permissions on the storage are configured correctly to be used as output target by the Bitmovin encoder. If \&quot;false\&quot;, *failureReason* will provide additional information.
        /// </summary>
        [JsonProperty(PropertyName = "passed")]
        public bool? Passed { get; internal set; }

        /// <summary>
        /// Contains nothing if the check succeeded. Otherwise, contains a message explaining why it failed.
        /// </summary>
        [JsonProperty(PropertyName = "failureReason")]
        public string FailureReason { get; internal set; }
    }
}
