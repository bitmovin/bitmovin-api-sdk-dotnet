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
    /// DolbyAtmosLoudnessControl
    /// </summary>
    public class DolbyAtmosLoudnessControl
    {
        /// <summary>
        /// Algorithm to be used for measuring loudness. Recommended value is \&quot;ITU_R_BS_1770_4\&quot; (required)
        /// </summary>
        [JsonProperty(PropertyName = "meteringMode")]
        public DolbyAtmosMeteringMode? MeteringMode { get; set; }

        /// <summary>
        /// Whether to use the Dialogue Intelligence feature, which identifies and analyzes dialogue segments within audio as a basis for speech gating. Must not be \&quot;DISABLED\&quot; for meteringMode \&quot;ITU-R BS.1770-1\&quot; or \&quot;Leq (A)\&quot;, otherwise recommended value is \&quot;ENABLED\&quot; (required)
        /// </summary>
        [JsonProperty(PropertyName = "dialogueIntelligence")]
        public DolbyAtmosDialogueIntelligence? DialogueIntelligence { get; set; }

        /// <summary>
        /// Specifies the percentage of speech that must be detected in the metered content before using the measured speech loudness as the overall program loudness. Given as an integer percentage between 0 and 100 (0% to 100%). Recommended value is 15 (required)
        /// </summary>
        [JsonProperty(PropertyName = "speechThreshold")]
        public int? SpeechThreshold { get; set; }
    }
}
