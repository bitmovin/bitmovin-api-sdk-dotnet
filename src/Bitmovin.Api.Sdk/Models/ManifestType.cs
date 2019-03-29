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
    /// ManifestType
    /// </summary>
    public enum ManifestType
    {
        /// <summary>
        /// MPEG-DASH manifest
        /// </summary>
        [EnumMember(Value = "DASH")]
        DASH,
        
        /// <summary>
        /// Apple HTTP Live Streaming manifest
        /// </summary>
        [EnumMember(Value = "HLS")]
        HLS,
        
        /// <summary>
        /// Microsoft Smooth Streaming manifest
        /// </summary>
        [EnumMember(Value = "SMOOTH_STREAMING")]
        SMOOTH_STREAMING
        
    }

}
