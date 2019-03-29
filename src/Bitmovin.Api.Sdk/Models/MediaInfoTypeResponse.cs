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
    /// MediaInfoTypeResponse
    /// </summary>

    public class MediaInfoTypeResponse
    {
        /// <summary>
        /// The type of the media-info
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public MediaInfoType Type { get; set; }
    }

}
