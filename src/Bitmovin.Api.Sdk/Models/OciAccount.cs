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
    /// OciAccount
    /// </summary>
    public class OciAccount : BitmovinResource
    {
        /// <summary>
        /// The OCID of the tenancy where you intend to run encoding VMs. (required)
        /// </summary>
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }

        /// <summary>
        /// The OCID of the compartment within the tenancy where you intend to run encoding VMs. (required)
        /// </summary>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
    }
}
