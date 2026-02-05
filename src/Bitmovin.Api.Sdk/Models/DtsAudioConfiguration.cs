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
#pragma warning disable CS0414
        private readonly string _type = "DTS";
#pragma warning restore CS0414

        /// <summary>
        /// There are two DTS modes available: DTS Express Audio (EXPRESS_AUDIO) and DTS Digital Surround (DIGITAL_SURROUND)
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DtsMode? Mode { get; set; }
    }
}
