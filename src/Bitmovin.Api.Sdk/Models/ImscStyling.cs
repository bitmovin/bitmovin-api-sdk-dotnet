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
    /// ImscStyling
    /// </summary>
    public class ImscStyling
    {
        /// <summary>
        /// Mode
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public ImscStylingMode? Mode { get; set; }
    }
}
