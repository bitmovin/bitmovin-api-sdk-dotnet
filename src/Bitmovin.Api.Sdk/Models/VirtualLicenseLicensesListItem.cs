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
    /// VirtualLicenseLicensesListItem
    /// </summary>
    public class VirtualLicenseLicensesListItem
    {
        /// <summary>
        /// Analytics License Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// Analytics License key
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// Organisation Id of license
        /// </summary>
        [JsonProperty(PropertyName = "orgId")]
        public string OrgId { get; set; }
    }
}
