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
    /// DolbyDigitalPreprocessing
    /// </summary>
    public class DolbyDigitalPreprocessing
    {
        /// <summary>
        /// It indicates a gain change to be applied in the Dolby Digital decoder in order to implement dynamic range compression.  The values typically indicate gain reductions (cut) during loud passages and gain increases (boost) during quiet passages based on desired compression characteristics. 
        /// </summary>
        [JsonProperty(PropertyName = "dynamicRangeCompression")]
        public DolbyDigitalDynamicRangeCompression DynamicRangeCompression { get; set; }

        /// <summary>
        /// It applies a 120 Hz low-pass filter to the low-frequency effects (LFE) channel.  This is only allowed if the &#x60;channelLayout&#x60; contains a LFE channel. 
        /// </summary>
        [JsonProperty(PropertyName = "lfeLowPassFilter")]
        public DolbyDigitalLfeLowPassFilter? LfeLowPassFilter { get; set; }

        /// <summary>
        /// NinetyDegreePhaseShift
        /// </summary>
        [JsonProperty(PropertyName = "ninetyDegreePhaseShift")]
        public DolbyDigitalNinetyDegreePhaseShift? NinetyDegreePhaseShift { get; set; }

        /// <summary>
        /// ThreeDbAttenuation
        /// </summary>
        [JsonProperty(PropertyName = "threeDbAttenuation")]
        public DolbyDigitalThreeDbAttenuation? ThreeDbAttenuation { get; set; }
    }
}
