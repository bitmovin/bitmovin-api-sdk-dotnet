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
    /// PccDeviceTypeShare
    /// </summary>
    public class PccDeviceTypeShare
    {
        /// <summary>
        /// The device type reported by the fleet. (required)
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Cells that played, across device pools of this kind. (required)
        /// </summary>
        [JsonProperty(PropertyName = "played")]
        public decimal? Played { get; set; }

        /// <summary>
        /// Cells with a device-answering verdict, across pools of this kind. The denominator. (required)
        /// </summary>
        [JsonProperty(PropertyName = "measured")]
        public decimal? Measured { get; set; }

        /// <summary>
        /// Device pools of this kind with at least one device-answering verdict. (required)
        /// </summary>
        [JsonProperty(PropertyName = "models")]
        public decimal? Models { get; set; }
    }
}
