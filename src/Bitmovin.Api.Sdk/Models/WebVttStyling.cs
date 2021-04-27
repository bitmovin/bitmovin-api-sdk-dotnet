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
    /// WebVttStyling
    /// </summary>
    public class WebVttStyling
    {
        /// <summary>
        /// Mode
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public WebVttStylingMode? Mode { get; set; }
    }
}
