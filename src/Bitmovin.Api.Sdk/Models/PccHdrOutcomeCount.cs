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
    /// PccHdrOutcomeCount
    /// </summary>
    public class PccHdrOutcomeCount
    {
        /// <summary>
        /// Outcome
        /// </summary>
        [JsonProperty(PropertyName = "outcome")]
        public PccHdrOutcome? Outcome { get; set; }

        /// <summary>
        /// Null only for unreported readings. Evidence includes both HDR and SDR outcomes. (required)
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public PccHdrConfidence? Confidence { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Selected HDR playback passes with this outcome. All six outcomes sum to HDR passes. (required)
        /// </summary>
        [JsonProperty(PropertyName = "cells")]
        public decimal? Cells { get; set; }
    }
}
