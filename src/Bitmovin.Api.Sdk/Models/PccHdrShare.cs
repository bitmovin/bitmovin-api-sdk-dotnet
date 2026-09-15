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
    /// PccHdrShare
    /// </summary>
    public class PccHdrShare
    {
        /// <summary>
        /// Confidence
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public PccHdrConfidence? Confidence { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Cells
        /// </summary>
        [JsonProperty(PropertyName = "cells")]
        public decimal? Cells { get; set; }
    }
}
