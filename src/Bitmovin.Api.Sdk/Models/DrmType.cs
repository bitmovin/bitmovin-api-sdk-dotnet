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
    /// DrmType
    /// </summary>
    public enum DrmType
    {
        /// <summary>
        /// The type of the drm
        /// </summary>
        [EnumMember(Value = "WIDEVINE")]
        WIDEVINE,
        
        /// <summary>
        /// The type of the drm
        /// </summary>
        [EnumMember(Value = "PLAYREADY")]
        PLAYREADY,
        
        /// <summary>
        /// The type of the drm
        /// </summary>
        [EnumMember(Value = "PRIMETIME")]
        PRIMETIME,
        
        /// <summary>
        /// The type of the drm
        /// </summary>
        [EnumMember(Value = "FAIRPLAY")]
        FAIRPLAY,
        
        /// <summary>
        /// The type of the drm
        /// </summary>
        [EnumMember(Value = "MARLIN")]
        MARLIN,
        
        /// <summary>
        /// The type of the drm
        /// </summary>
        [EnumMember(Value = "CLEARKEY")]
        CLEARKEY,
        
        /// <summary>
        /// The type of the drm
        /// </summary>
        [EnumMember(Value = "AES")]
        AES,
        
        /// <summary>
        /// The type of the drm
        /// </summary>
        [EnumMember(Value = "CENC")]
        CENC,
        
        /// <summary>
        /// The type of the drm
        /// </summary>
        [EnumMember(Value = "SPEKE")]
        SPEKE
        
    }

}
