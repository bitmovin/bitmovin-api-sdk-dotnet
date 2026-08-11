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
    /// DolbyLoudnessFilter
    /// </summary>
    public class DolbyLoudnessFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "DOLBY_LOUDNESS";
#pragma warning restore CS0414

        /// <summary>
        /// The target integrated loudness the audio should be corrected to. Range is from &#39;-31&#39; to &#39;-8&#39;. Default value is &#39;-24&#39;. Value is measured in LKFS (Loudness, K-weighted, relative to Full Scale).
        /// </summary>
        [JsonProperty(PropertyName = "targetLoudness")]
        public int? TargetLoudness { get; set; }

        /// <summary>
        /// The maximum true-peak level the corrected audio may reach. Range is from &#39;-8.0&#39; to &#39;-0.1&#39;. Default value is &#39;-2.0&#39;. Values are measured in dBTP (dB True Peak). Note that the maximum true peak level must be set at least 6 dB above the target loudness.
        /// </summary>
        [JsonProperty(PropertyName = "maximumTruePeakLevel")]
        public double? MaximumTruePeakLevel { get; set; }

        /// <summary>
        /// Whether to use the Dolby Dialogue Intelligence feature, which identifies and analyzes dialogue segments within the audio as a basis for speech gating. Default value is &#39;ENABLED&#39;.
        /// </summary>
        [JsonProperty(PropertyName = "dialogueIntelligence")]
        public DolbyLoudnessDialogueIntelligence? DialogueIntelligence { get; set; }

        /// <summary>
        /// The percentage of speech that must be detected within the audio before the dialogue loudness is used as the basis for loudness correction. Range is from &#39;0&#39; to &#39;100&#39;. Default value is &#39;20&#39;. This is only applied when dialogueIntelligence is &#39;ENABLED&#39;, as it selects between speech-gated and un-gated loudness measurement.
        /// </summary>
        [JsonProperty(PropertyName = "speechDetectionThreshold")]
        public int? SpeechDetectionThreshold { get; set; }

        /// <summary>
        /// The form of the content, used to optimize the loudness measurement gating. Content longer than 3 minutes (180 seconds) is considered long-form, shorter content is considered short-form. Default value is &#39;AUTO_DETECT&#39;.
        /// </summary>
        [JsonProperty(PropertyName = "contentForm")]
        public DolbyLoudnessContentForm? ContentForm { get; set; }
    }
}
