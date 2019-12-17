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
    /// BurnInSubtitleDvbSub
    /// </summary>

    public class BurnInSubtitleDvbSub : BitmovinResource
    {
        /// <summary>
        /// Id of an IngestInputStream which specifies the stream of the DVB-SUB subtitles (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputStreamId")]
        public string InputStreamId { get; set; }
    }

}
