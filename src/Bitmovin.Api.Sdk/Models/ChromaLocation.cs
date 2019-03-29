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
    /// ChromaLocation
    /// </summary>
    public enum ChromaLocation
    {
        /// <summary>
        /// Unspecified ChromaLocation
        /// </summary>
        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,
        
        /// <summary>
        /// Left ChromaLocation
        /// </summary>
        [EnumMember(Value = "LEFT")]
        LEFT,
        
        /// <summary>
        /// Center ChromaLocation
        /// </summary>
        [EnumMember(Value = "CENTER")]
        CENTER,
        
        /// <summary>
        /// Topleft ChromaLocation
        /// </summary>
        [EnumMember(Value = "TOPLEFT")]
        TOPLEFT,
        
        /// <summary>
        /// Top ChromaLocation
        /// </summary>
        [EnumMember(Value = "TOP")]
        TOP,
        
        /// <summary>
        /// Bottomleft ChromaLocation
        /// </summary>
        [EnumMember(Value = "BOTTOMLEFT")]
        BOTTOMLEFT,
        
        /// <summary>
        /// Bottom ChromaLocation
        /// </summary>
        [EnumMember(Value = "BOTTOM")]
        BOTTOM
        
    }

}
