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
    /// AzureSpeechToCaptionsFilter
    /// </summary>
    public class AzureSpeechToCaptionsFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "AZURE_SPEECH_TO_CAPTIONS";

        /// <summary>
        /// AzureSpeechToCaptionsSettings
        /// </summary>
        [JsonProperty(PropertyName = "azureSpeechToCaptionsSettings")]
        public AzureSpeechToCaptionsSettings AzureSpeechToCaptionsSettings { get; set; }
    }
}
