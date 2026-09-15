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
    /// PccDevice
    /// </summary>
    public class PccDevice
    {
        /// <summary>
        /// The device pool, as the reader is shown it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// True where no naming rule recognised this pool, so &#x60;name&#x60; is a stated placeholder rather than the pool&#39;s own. The units and sessions below still tell two such pools apart. (required)
        /// </summary>
        [JsonProperty(PropertyName = "namePlaceholder")]
        public bool? NamePlaceholder { get; set; }

        /// <summary>
        /// What distinguishes this pool from another of the same name, where anything does.
        /// </summary>
        [JsonProperty(PropertyName = "qualifier")]
        public string Qualifier { get; set; }

        /// <summary>
        /// The fleet&#39;s own classification, such as &#x60;tv&#x60;, &#x60;desktop&#x60;, &#x60;stb&#x60; or &#x60;mobile&#x60;. Never one guessed from a name, and not a closed set: the fleet may answer with a kind this list does not name.
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public string DeviceType { get; set; }

        /// <summary>
        /// SessionIds
        /// </summary>
        [JsonProperty(PropertyName = "sessionIds")]
        public List<string> SessionIds { get; set; } = new List<string>();

        /// <summary>
        /// Units
        /// </summary>
        [JsonProperty(PropertyName = "units")]
        public List<PccDeviceUnit> Units { get; set; } = new List<PccDeviceUnit>();

        /// <summary>
        /// Every player version that measured this pool. More than one means the runs spanned a player release. (required)
        /// </summary>
        [JsonProperty(PropertyName = "playerVersions")]
        public List<string> PlayerVersions { get; set; } = new List<string>();

        /// <summary>
        /// One per column, in &#x60;combinations&#x60; order. (required)
        /// </summary>
        [JsonProperty(PropertyName = "cells")]
        public List<PccCell> Cells { get; set; } = new List<PccCell>();
    }
}
