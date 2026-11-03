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
    /// A song identified in the video credits. Retains its original values in language-specific results.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Song title extracted from the credit text.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Artist associated with the song in the credit text.
        /// </summary>
        [JsonProperty(PropertyName = "artist")]
        public string Artist { get; set; }
    }
}
