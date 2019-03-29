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
    /// XmlNamespace
    /// </summary>

    public class XmlNamespace
    {
        /// <summary>
        /// Name of the XML Namespace reference
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        /// <summary>
        /// Source of the XML Namespace reference
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }

}
