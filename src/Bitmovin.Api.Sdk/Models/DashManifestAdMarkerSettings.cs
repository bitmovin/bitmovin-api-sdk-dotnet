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
    /// An optional configuration object used to define SCTE-35 signaling for ad insertion or content segmentation.  This field enables precise control over signaling behavior at both the period and event stream levels,  making it suitable for dynamic ad insertion (DAI) and live streaming workflows. This follows the ANSI/SCTE 214-1 (2024) standard. 
    /// </summary>
    public class DashManifestAdMarkerSettings
    {
        /// <summary>
        /// PeriodOption
        /// </summary>
        [JsonProperty(PropertyName = "periodOption")]
        public DashScte35PeriodOption? PeriodOption { get; set; }

        /// <summary>
        /// EventStreamSignalling
        /// </summary>
        [JsonProperty(PropertyName = "eventStreamSignalling")]
        public DashScte35EventStreamSignalling? EventStreamSignalling { get; set; }
    }
}
