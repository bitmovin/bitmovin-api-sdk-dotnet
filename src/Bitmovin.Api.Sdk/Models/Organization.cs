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
    /// Organization
    /// </summary>
    public class Organization : BitmovinResource
    {
        /// <summary>
        /// Specifies the type of the organization in the hierachy. Only sub-organizations can be newly created. (required)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public OrganizationType? Type { get; set; }

        /// <summary>
        /// ID of the parent organization
        /// </summary>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; internal set; }

        /// <summary>
        /// Hexadecimal color
        /// </summary>
        [JsonProperty(PropertyName = "labelColor")]
        public string LabelColor { get; set; }

        /// <summary>
        /// LimitsPerResource
        /// </summary>
        [JsonProperty(PropertyName = "limitsPerResource")]
        public List<ResourceLimitContainer> LimitsPerResource { get; set; } = new List<ResourceLimitContainer>();

        /// <summary>
        /// which platform initiated organisation creation
        /// </summary>
        [JsonProperty(PropertyName = "signupSource")]
        public SignupSource? SignupSource { get; internal set; }

        /// <summary>
        /// Flag indicating if MFA is required for the organization
        /// </summary>
        [JsonProperty(PropertyName = "mfaRequired")]
        public bool? MfaRequired { get; internal set; }
    }
}
