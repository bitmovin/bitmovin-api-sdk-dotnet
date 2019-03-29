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
    /// AudioAdaptationSet
    /// </summary>

    public class AudioAdaptationSet : AdaptationSet
    {
        /// <summary>
        /// ISO 639-1 (Alpha-2) code identifying the language of the audio adaptation set
        /// </summary>
        [JsonProperty(PropertyName = "lang")]
        public string Lang { get; set; }
    }

}
