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
    /// FragmentedMp4MuxingManifestType
    /// </summary>
    public enum FragmentedMp4MuxingManifestType
    {
        /// <summary>
        /// Smooth Streaming manifest
        /// </summary>
        [EnumMember(Value = "SMOOTH")]
        SMOOTH,
        
        /// <summary>
        /// DASH On-demand manifest
        /// </summary>
        [EnumMember(Value = "DASH_ON_DEMAND")]
        DASH_ON_DEMAND,
        
        /// <summary>
        /// HLS manifest with byte ranges
        /// </summary>
        [EnumMember(Value = "HLS_BYTE_RANGES")]
        HLS_BYTE_RANGES,
        
        /// <summary>
        /// Dont create a manifest
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// HLS manifest with byte ranges and I-frame playlist
        /// </summary>
        [EnumMember(Value = "HLS_BYTE_RANGES_AND_IFRAME_PLAYLIST")]
        HLS_BYTE_RANGES_AND_IFRAME_PLAYLIST
        
    }

}
