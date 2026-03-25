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
    /// AllSceneBoundaries
    /// </summary>
    public class AllSceneBoundaries
    {
        /// <summary>
        /// If true, a keyframe (IDR frame) is placed at every detected scene boundary, enabling clean segment cuts aligned with scene changes. 
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// If true, cue tags are inserted at every scene boundary in addition to keyframes. 
        /// </summary>
        [JsonProperty(PropertyName = "insertCueTags")]
        public bool? InsertCueTags { get; set; }
    }
}
