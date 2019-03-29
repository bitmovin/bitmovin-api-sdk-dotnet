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
    /// SourceChannelType
    /// </summary>
    public enum SourceChannelType
    {
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "CHANNEL_NUMBER")]
        CHANNELNUMBER,
        
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "FRONT_LEFT")]
        FRONTLEFT,
        
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "FRONT_RIGHT")]
        FRONTRIGHT,
        
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "CENTER")]
        CENTER,
        
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "LOW_FREQUENCY")]
        LOWFREQUENCY,
        
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "BACK_LEFT")]
        BACKLEFT,
        
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "BACK_RIGHT")]
        BACKRIGHT,
        
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "SURROUND_LEFT")]
        SURROUNDLEFT,
        
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "SURROUND_RIGHT")]
        SURROUNDRIGHT
        
    }

}
