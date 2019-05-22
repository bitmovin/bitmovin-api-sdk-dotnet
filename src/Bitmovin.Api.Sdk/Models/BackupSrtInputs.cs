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
    /// BackupSrtInputs
    /// </summary>

    public class BackupSrtInputs
    {
        /// <summary>
        /// When there is no input signal present for this number of seconds, the encoder will switch to the next input
        /// </summary>
        [JsonProperty(PropertyName = "delayThreshold")]
        public int? DelayThreshold { get; set; }
        
        /// <summary>
        /// SrtInputs
        /// </summary>
        [JsonProperty(PropertyName = "srtInputs")]
        public List<SrtInput> SrtInputs { get; set; }
    }

}
