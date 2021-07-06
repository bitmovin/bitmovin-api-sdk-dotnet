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
    /// DolbyDigitalLoudnessControl
    /// </summary>
    public class DolbyDigitalLoudnessControl
    {
        /// <summary>
        /// Dialogue Normalization value to be set on the bitstream metadata. Required if the mode is &#x60;PASSTHROUGH&#x60;, or if the mode is &#x60;CORRECTION&#x60; and regulationType is &#x60;MANUAL&#x60;. For all other combinations dialnorm must not be set.
        /// </summary>
        [JsonProperty(PropertyName = "dialnorm")]
        public int? Dialnorm { get; set; }

        /// <summary>
        /// This may only be set if the mode is &#x60;PASSTHROUGH&#x60;, or if the mode is &#x60;CORRECTION&#x60; and regulationType is &#x60;MANUAL&#x60;. For all other combinations dialogueIntelligence must not be set.
        /// </summary>
        [JsonProperty(PropertyName = "dialogueIntelligence")]
        public DolbyDigitalDialogueIntelligence? DialogueIntelligence { get; set; }

        /// <summary>
        /// Mode
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DolbyDigitalLoudnessControlMode? Mode { get; set; }

        /// <summary>
        /// The peak value in dB to use for loudness correction. This may only be set if the mode is &#x60;PASSTHROUGH&#x60;, or if the mode is &#x60;CORRECTION&#x60; and regulationType is &#x60;MANUAL&#x60;. For all other combinations peakLimit must not be set.
        /// </summary>
        [JsonProperty(PropertyName = "peakLimit")]
        public double? PeakLimit { get; set; }

        /// <summary>
        /// This is only allowed if the mode is CORRECTION. &lt;table&gt; &lt;tr&gt;&lt;th colspan&#x3D;4 align&#x3D;\&quot;left\&quot;&gt; Predefined values for each regulation type: &lt;/th&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; Regulation Type &lt;/td&gt;&lt;td&gt; EBU R128 &lt;/td&gt;&lt;td&gt; ATSC A/85 Fixed &lt;/td&gt;&lt;td&gt; ATSC A/85 Agile&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; Limit Mode &lt;/td&gt;&lt;td&gt; &#x60;True Peak&#x60; &lt;/td&gt;&lt;td&gt; &#x60;True Peak&#x60; &lt;/td&gt;&lt;td&gt; &#x60;True Peak&#x60; &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; Correction Mode &lt;/td&gt;&lt;td&gt; &#x60;PCM Normalization&#x60; &lt;/td&gt;&lt;td&gt; &#x60;PCM Normalization&#x60; &lt;/td&gt;&lt;td&gt; &#x60;Metadata Update&#x60; &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; Peak Limit &lt;/td&gt;&lt;td&gt; &#x60;–3 dBTP&#x60; &lt;/td&gt;&lt;td&gt; &#x60;–2 dBTP&#x60; &lt;/td&gt;&lt;td&gt; &#x60;N/A&#x60; &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; Dialogue Intelligence &lt;/td&gt;&lt;td&gt; &#x60;Off&#x60; &lt;/td&gt;&lt;td&gt; &#x60;On&#x60; &lt;/td&gt;&lt;td&gt; &#x60;On&#x60; &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; Meter Mode &lt;/td&gt;&lt;td&gt; &#x60;ITU-R BS.1770-3&#x60; &lt;/td&gt;&lt;td&gt; &#x60;ITU-R BS.1770-3&#x60; &lt;/td&gt;&lt;td&gt; &#x60;ITU-R BS.1770-3&#x60; &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; Speech Threshold &lt;/td&gt;&lt;td&gt; &#x60;20&#x60; &lt;/td&gt;&lt;td&gt; &#x60;20&#x60; &lt;/td&gt;&lt;td&gt; &#x60;20&#x60; &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; Dialogue Normalization &lt;/td&gt;&lt;td&gt; &#x60;-23 dB&#x60; &lt;/td&gt;&lt;td&gt; &#x60;-24 dB&#x60; &lt;/td&gt;&lt;td&gt; &#x60;Set to measured loudness&#x60; &lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        [JsonProperty(PropertyName = "regulationType")]
        public DolbyDigitalLoudnessControlRegulationType? RegulationType { get; set; }
    }
}
