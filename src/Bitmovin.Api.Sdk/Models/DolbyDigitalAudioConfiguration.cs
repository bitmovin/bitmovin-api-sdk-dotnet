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
    /// DolbyDigitalAudioConfiguration
    /// </summary>
    public class DolbyDigitalAudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "DD";

        /// <summary>
        /// BitstreamInfo defines metadata parameters contained in the Dolby Digital audio bitstream
        /// </summary>
        [JsonProperty(PropertyName = "bitstreamInfo")]
        public DolbyDigitalBitstreamInfo BitstreamInfo { get; set; }

        /// <summary>
        /// Channel layout of the audio codec configuration. &lt;table&gt; &lt;tr&gt;&lt;th colspan&#x3D;2 align&#x3D;\&quot;left\&quot;&gt; Available values: &lt;/th&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; NONE &lt;/td&gt;&lt;td&gt; No channel layout &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; MONO &lt;/td&gt;&lt;td&gt; Channel layout Mono &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; STEREO &lt;/td&gt;&lt;td&gt; Channel layout Stereo &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; SURROUND &lt;/td&gt;&lt;td&gt; Channel layout 3.0 (3 front (left + center + right), no LFE) &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; 3.1 &lt;/td&gt;&lt;td&gt; Channel layout 3.1 (3 front (left + center + right), LFE) &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; BACK_SURROUND &lt;/td&gt;&lt;td&gt; Channel layout Surround (2 front (left + right), 1 back center, no LFE) &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; BACK_SURROUND_LFE &lt;/td&gt;&lt;td&gt; Channel layout Surround with LFE (2 front (left + right), 1 back center, LFE) &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; QUAD &lt;/td&gt;&lt;td&gt; Channel layout Quad (2 front (left + right), 2 back (left + right), no LFE) &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; QUAD_LFE &lt;/td&gt;&lt;td&gt; Channel layout Quad with LFE (2 front (left + right), 2 back (left + right), LFE) &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; 4.0 &lt;/td&gt;&lt;td&gt; Channel layout 4.0 (3 front (left + center + right), 1 back center, no LFE) &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; 4.1 &lt;/td&gt;&lt;td&gt; Channel layout 4.1 (3 front (left + center + right), 1 back center, LFE) &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; 5.0 &lt;/td&gt;&lt;td&gt; Channel layout 5.0 (3 front (left + center + right), 2 side (left + right), no LFE) &lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt; 5.1 &lt;/td&gt;&lt;td&gt; Channel layout 5.1 (3 front (left + center + right), 2 side (left + right), LFE) &lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public DolbyDigitalChannelLayout? ChannelLayout { get; set; }

        /// <summary>
        /// Downmixing
        /// </summary>
        [JsonProperty(PropertyName = "downmixing")]
        public DolbyDigitalDownmixing Downmixing { get; set; }

        /// <summary>
        /// It provides a framework for signaling new evolution framework applications, such as Intelligent Loudness, in each Dolby codec. 
        /// </summary>
        [JsonProperty(PropertyName = "evolutionFrameworkControl")]
        public DolbyDigitalEvolutionFrameworkControl? EvolutionFrameworkControl { get; set; }

        /// <summary>
        /// Settings for loudness control (required)
        /// </summary>
        [JsonProperty(PropertyName = "loudnessControl")]
        public DolbyDigitalLoudnessControl LoudnessControl { get; set; }

        /// <summary>
        /// Preprocessing
        /// </summary>
        [JsonProperty(PropertyName = "preprocessing")]
        public DolbyDigitalPreprocessing Preprocessing { get; set; }
    }
}
