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
    /// PaddingSequence
    /// </summary>

    public class PaddingSequence
    {
        /// <summary>
        /// Duration of the padding sequence, given in the unit specified by the &#x60;unit&#x60; property. The maximum duration is 300 frames or 10 seconds. If the unit is &#x60;FRAMES&#x60;, this needs to be an integer value and will be interpreted based on the input frame rate of the main part of the ConcatenationInputStream that is used by your video output stream(s). &#x60;FRAMES&#x60; is not allowed if the encoding does not contain a video output stream. (required)
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }
        
        /// <summary>
        /// The unit of the &#x60;duration&#x60; property
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public PaddingDurationUnit? Unit { get; set; }
    }

}
