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
    /// PccVerdictShare
    /// </summary>
    public class PccVerdictShare
    {
        /// <summary>
        /// Verdict
        /// </summary>
        [JsonProperty(PropertyName = "verdict")]
        public PccVerdict? Verdict { get; set; }

        /// <summary>
        /// The reader&#39;s word for it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Cells sharing this label, including verdicts grouped under &#x60;Not measured&#x60;. (required)
        /// </summary>
        [JsonProperty(PropertyName = "cells")]
        public decimal? Cells { get; set; }

        /// <summary>
        /// False where the verdict says something about the measurement, not about the device. (required)
        /// </summary>
        [JsonProperty(PropertyName = "aboutTheDevice")]
        public bool? AboutTheDevice { get; set; }
    }
}
