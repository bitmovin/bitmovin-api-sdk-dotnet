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
    /// SmoothManifestDefaultVersion
    /// </summary>
    public enum SmoothManifestDefaultVersion
    {
        /// <summary>
        /// V1
        /// </summary>
        [EnumMember(Value = "V1")]
        V1
        
    }

}
