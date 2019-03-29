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
    /// ErrorDetails
    /// </summary>

    public class ErrorDetails
    {
        /// <summary>
        /// Specific error code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }
        
        /// <summary>
        /// Error group name
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        
        /// <summary>
        /// Detailed error message
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <summary>
        /// Information if the encoding could potentially succeed when retrying.
        /// </summary>
        [JsonProperty(PropertyName = "retryHint")]
        public RetryHint RetryHint { get; set; }
    }

}
