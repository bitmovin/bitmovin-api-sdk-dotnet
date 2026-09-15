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
    /// PccSummary
    /// </summary>
    public class PccSummary
    {
        /// <summary>
        /// Overview
        /// </summary>
        [JsonProperty(PropertyName = "overview")]
        public PccOverview Overview { get; set; }

        /// <summary>
        /// CodecReach
        /// </summary>
        [JsonProperty(PropertyName = "codecReach")]
        public List<PccCodecReach> CodecReach { get; set; } = new List<PccCodecReach>();

        /// <summary>
        /// Selected applicable codec/protection combinations with no device-answering verdict. Declared unsupported and claimed-but-not-played are answers; inapplicable pairings are not gaps. (required)
        /// </summary>
        [JsonProperty(PropertyName = "unansweredCombinations")]
        public int? UnansweredCombinations { get; set; }

        /// <summary>
        /// Verdicts
        /// </summary>
        [JsonProperty(PropertyName = "verdicts")]
        public List<PccVerdictShare> Verdicts { get; set; } = new List<PccVerdictShare>();

        /// <summary>
        /// ByCodec
        /// </summary>
        [JsonProperty(PropertyName = "byCodec")]
        public List<PccSupportShare> ByCodec { get; set; } = new List<PccSupportShare>();

        /// <summary>
        /// ByProtection
        /// </summary>
        [JsonProperty(PropertyName = "byProtection")]
        public List<PccSupportShare> ByProtection { get; set; } = new List<PccSupportShare>();

        /// <summary>
        /// ByDeviceType
        /// </summary>
        [JsonProperty(PropertyName = "byDeviceType")]
        public List<PccDeviceTypeShare> ByDeviceType { get; set; } = new List<PccDeviceTypeShare>();

        /// <summary>
        /// Every selected combination, with what the selected device pools answered about it. One that several pools claimed and none played points at the stream rather than at the devices. (required)
        /// </summary>
        [JsonProperty(PropertyName = "combinations")]
        public List<PccCombinationEvidence> Combinations { get; set; } = new List<PccCombinationEvidence>();

        /// <summary>
        /// Hdr
        /// </summary>
        [JsonProperty(PropertyName = "hdr")]
        public PccHdrSummary Hdr { get; set; }
    }
}
