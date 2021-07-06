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
    /// DolbyDigitalPlusBitstreamInfo
    /// </summary>
    public class DolbyDigitalPlusBitstreamInfo
    {
        /// <summary>
        /// This parameter indicates to a decoder whether the two‐channel encoded bitstream contains a Dolby Surround (Lt/Rt) program that requires Dolby Pro Logic decoding.  When downmixing to stereo from a multichannel input, set this value according to the type of downmix performed (Lt/Rt: &#x60;ENABLED&#x60;, Lo/Ro: &#x60;DISABLED&#x60;). When transcoding a stereo Dolby Digital, Dolby Digital Plus, or Dolby E input, the value must be passed through from the input bitstream to the output bitstream. When transcoding a third-party stereo input to stereo Dolby Digital set the value to &#x60;NOT_INDICATED&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "surroundMode")]
        public DolbyDigitalPlusSurroundMode? SurroundMode { get; set; }

        /// <summary>
        /// This is used to identify the encoded audio as material encoded in Dolby Digital Surround EX. This parameter is used only if the encoded audio has two surround channels.  An amplifier or receiver with Dolby Digital Surround EX decoding can use this parameter as a flag to switch the decoding on or off automatically. The behavior is similar to that of the &#x60;surroundMode&#x60; parameter. 
        /// </summary>
        [JsonProperty(PropertyName = "surroundExMode")]
        public DolbyDigitalPlusSurroundMode? SurroundExMode { get; set; }
    }
}
