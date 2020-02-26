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
    /// BroadcastTsAudioInputStreamConfiguration
    /// </summary>
    public class BroadcastTsAudioInputStreamConfiguration : BroadcastTsInputStreamConfiguration
    {
        /// <summary>
        /// Use ATSC buffer model for AC-3. If true, use the ATSC version of the T-STD buffer model is used. This parameter applies to AC-3 streams only.
        /// </summary>
        [JsonProperty(PropertyName = "useATSCBufferModel")]
        public bool? UseATSCBufferModel { get; set; }

        /// <summary>
        /// Language of the audio stream. Specified according to the ISO 639-2 alpha code for the language descriptor.
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
    }
}
