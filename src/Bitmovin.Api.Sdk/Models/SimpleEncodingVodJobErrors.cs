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
    /// SimpleEncodingVodJobErrors
    /// </summary>
    public class SimpleEncodingVodJobErrors
    {
        /// <summary>
        /// Stable code that identifies the error type.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; internal set; }

        /// <summary>
        /// Human readable description of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; internal set; }

        /// <summary>
        /// Additional details of the error if available.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; internal set; }
    }
}
