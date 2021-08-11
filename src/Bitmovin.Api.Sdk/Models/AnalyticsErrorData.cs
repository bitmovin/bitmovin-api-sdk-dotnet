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
    /// AnalyticsErrorData
    /// </summary>
    public class AnalyticsErrorData
    {
        /// <summary>
        /// Exception message
        /// </summary>
        [JsonProperty(PropertyName = "exceptionMessage")]
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// Additional error data
        /// </summary>
        [JsonProperty(PropertyName = "additionalData")]
        public string AdditionalData { get; set; }

        /// <summary>
        /// ExceptionStacktrace
        /// </summary>
        [JsonProperty(PropertyName = "exceptionStacktrace")]
        public List<string> ExceptionStacktrace { get; set; } = new List<string>();
    }
}
