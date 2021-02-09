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
    /// AnalyticsOutput
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsS3RoleBasedOutput), "S3_ROLE_BASED")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsGcsServiceAccountOutput), "GCS_SERVICE_ACCOUNT")]

    public class AnalyticsOutput : BitmovinResource
    {
        /// <summary>
        /// Acl
        /// </summary>
        [JsonProperty(PropertyName = "acl")]
        public List<AclEntry> Acl { get; set; } = new List<AclEntry>();
    }
}
