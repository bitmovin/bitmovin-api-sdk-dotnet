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
    /// CustomXmlElement
    /// </summary>
    public class CustomXmlElement : BitmovinResponse
    {
        /// <summary>
        /// String representation of the XML element (required)
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }
    }
}
