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
    /// VirtualLicense
    /// </summary>
    public class VirtualLicense : BitmovinResponse
    {
        /// <summary>
        /// Name of the Virtual License
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The timezone of the Virtual License
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// List of Analytics Licenses
        /// </summary>
        [JsonProperty(PropertyName = "licenses")]
        public List<VirtualLicenseLicensesListItem> Licenses { get; set; } = new List<VirtualLicenseLicensesListItem>();
    }
}
