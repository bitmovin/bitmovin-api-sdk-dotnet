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
    /// SimpleEncodingLiveJobGcsServiceAccountCredentials
    /// </summary>
    public class SimpleEncodingLiveJobGcsServiceAccountCredentials : SimpleEncodingLiveJobCredentials
    {
        /// <summary>
        /// Service account credentials for Google (required)
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccountCredentials")]
        public string ServiceAccountCredentials { get; set; }
    }
}
