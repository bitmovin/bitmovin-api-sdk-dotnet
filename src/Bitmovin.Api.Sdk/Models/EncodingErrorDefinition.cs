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
    /// EncodingErrorDefinition
    /// </summary>

    public class EncodingErrorDefinition
    {
        /// <summary>
        /// The error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }
        
        /// <summary>
        /// The error category.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        
        /// <summary>
        /// The error message, optional. Can include placeholders like {1}, {2} which are replaced with the respective dependency when the error is thrown.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <summary>
        /// The returned error description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <summary>
        /// Indicates if the call that caused the error should be retried.
        /// </summary>
        [JsonProperty(PropertyName = "retryHint")]
        public ErrorRetryHint? RetryHint { get; set; }
    }

}
