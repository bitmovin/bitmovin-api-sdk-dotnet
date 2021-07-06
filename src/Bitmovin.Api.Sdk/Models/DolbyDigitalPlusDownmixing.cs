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
    /// Downmixing is used to reproduce the complete audio program when the actual decoder outputs do not match the encoded channel layout of the original audio signal.  The process of downmixing takes the information in the channels that do not have corresponding outputs, and mixes this information into the remaining channels. 
    /// </summary>
    public class DolbyDigitalPlusDownmixing
    {
        /// <summary>
        /// The level shift applied to the C channel when adding to the L and R outputs as a result of downmixing to one Lo/Ro output.
        /// </summary>
        [JsonProperty(PropertyName = "loRoCenterMixLevel")]
        public DolbyDigitalPlusCenterMixLevel? LoRoCenterMixLevel { get; set; }

        /// <summary>
        /// The level shift applied to the C channel when adding to the L and R outputs as a result of downmixing to one Lt/Rt output.
        /// </summary>
        [JsonProperty(PropertyName = "ltRtCenterMixLevel")]
        public DolbyDigitalPlusCenterMixLevel? LtRtCenterMixLevel { get; set; }

        /// <summary>
        /// The level shift applied to the surround channels when downmixing to one Lo/Ro output.
        /// </summary>
        [JsonProperty(PropertyName = "loRoSurroundMixLevel")]
        public DolbyDigitalPlusSurroundMixLevel? LoRoSurroundMixLevel { get; set; }

        /// <summary>
        /// The level shift applied to the surround channels when downmixing to one Lt/Rt output.
        /// </summary>
        [JsonProperty(PropertyName = "ltRtSurroundMixLevel")]
        public DolbyDigitalPlusSurroundMixLevel? LtRtSurroundMixLevel { get; set; }

        /// <summary>
        /// PreferredMode
        /// </summary>
        [JsonProperty(PropertyName = "preferredMode")]
        public DolbyDigitalPlusDownmixingPreferredMode? PreferredMode { get; set; }
    }
}
