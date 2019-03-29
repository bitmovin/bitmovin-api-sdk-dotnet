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
    /// S3SignatureVersion
    /// </summary>
    public enum S3SignatureVersion
    {
        /// <summary>
        /// V2
        /// </summary>
        [EnumMember(Value = "S3_V2")]
        V2,
        
        /// <summary>
        /// V4
        /// </summary>
        [EnumMember(Value = "S3_V4")]
        V4
        
    }

}
