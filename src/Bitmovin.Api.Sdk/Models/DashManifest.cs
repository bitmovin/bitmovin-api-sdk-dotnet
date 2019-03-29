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
    /// DashManifest
    /// </summary>

    public class DashManifest : Manifest
    {
        /// <summary>
        /// Profile
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public DashProfile Profile { get; set; }
        
        /// <summary>
        /// The filename of your manifest
        /// </summary>
        [JsonProperty(PropertyName = "manifestName")]
        public string ManifestName { get; set; }
        
        /// <summary>
        /// List of additional XML namespaces to add to the DASH Manifest
        /// </summary>
        [JsonProperty(PropertyName = "namespaces")]
        public List<XmlNamespace> Namespaces { get; set; }
        
        /// <summary>
        /// List of UTC Timings to use for live streaming
        /// </summary>
        [JsonProperty(PropertyName = "utcTimings")]
        public List<UtcTiming> UtcTimings { get; set; }
    }

}
