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
    /// DtsAudioConfiguration
    /// </summary>
    public class DtsAudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "DTS";

        /// <summary>
        /// There are two DTS modes available: DTS Express Audio (EXPRESS_AUDIO) and DTS Digital Surround (DIGITAL_SURROUND)
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DtsMode? Mode { get; set; }
    }
}
