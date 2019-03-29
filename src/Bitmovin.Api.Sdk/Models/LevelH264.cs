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
    /// LevelH264
    /// </summary>
    public enum LevelH264
    {
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "1")]
        L1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "1b")]
        L1b,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "1.1")]
        L1_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "1.2")]
        L1_2,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "1.3")]
        L1_3,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "2")]
        L2,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "2.1")]
        L2_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "2.2")]
        L2_2,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "3")]
        L3,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "3.1")]
        L3_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "3.2")]
        L3_2,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "4")]
        L4,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "4.1")]
        L4_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "4.2")]
        L4_2,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "5")]
        L5,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "5.1")]
        L5_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "5.2")]
        L5_2
        
    }

}
