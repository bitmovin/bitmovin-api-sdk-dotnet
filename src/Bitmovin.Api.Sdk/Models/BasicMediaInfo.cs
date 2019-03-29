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
    /// BasicMediaInfo
    /// </summary>

    public class BasicMediaInfo : BitmovinResponse
    {
        /// <summary>
        /// The value is a quoted-string which specifies the group to which the Rendition belongs.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }
        
        /// <summary>
        /// Primary language in the rendition.
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
        
        /// <summary>
        /// Identifies a language that is associated with the Rendition.
        /// </summary>
        [JsonProperty(PropertyName = "assocLanguage")]
        public string AssocLanguage { get; set; }
        
        /// <summary>
        /// Human readable description of the rendition.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <summary>
        /// If set to true, the client SHOULD play this Rendition of the content in the absence of information from the user.
        /// </summary>
        [JsonProperty(PropertyName = "isDefault")]
        public bool? IsDefault { get; set; }
        
        /// <summary>
        /// If set to true, the client MAY choose to play this Rendition in the absence of explicit user preference.
        /// </summary>
        [JsonProperty(PropertyName = "autoselect")]
        public bool? Autoselect { get; set; }
        
        /// <summary>
        /// Contains Uniform Type Identifiers
        /// </summary>
        [JsonProperty(PropertyName = "characteristics")]
        public List<string> Characteristics { get; set; }
    }

}
