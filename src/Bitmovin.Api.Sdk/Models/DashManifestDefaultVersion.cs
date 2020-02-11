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
    /// DashManifestDefaultVersion
    /// </summary>
    public enum DashManifestDefaultVersion
    {
        /// <summary>
        /// V1
        /// </summary>
        [EnumMember(Value = "V1")]
        V1,
        
        /// <summary>
        /// V2
        /// </summary>
        [EnumMember(Value = "V2")]
        V2
        
    }

}
