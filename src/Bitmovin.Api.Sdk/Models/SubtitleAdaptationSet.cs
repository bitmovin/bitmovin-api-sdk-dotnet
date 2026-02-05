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
    /// SubtitleAdaptationSet
    /// </summary>
    public class SubtitleAdaptationSet : AdaptationSet
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "SUBTITLE";
#pragma warning restore CS0414

        /// <summary>
        /// ISO 639-1 (Alpha-2) code identifying the language of the subtitle adaptation set (required)
        /// </summary>
        [JsonProperty(PropertyName = "lang")]
        public string Lang { get; set; }
    }
}
