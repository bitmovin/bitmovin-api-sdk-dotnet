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
    /// LevelH265
    /// </summary>
    public enum LevelH265
    {
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "1")]
        L1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "2")]
        L2,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "2.1")]
        L2_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "3")]
        L3,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "3.1")]
        L3_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "4")]
        L4,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "4.1")]
        L4_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "5")]
        L5,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "5.1")]
        L5_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "5.2")]
        L5_2,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "6")]
        L6,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "6.1")]
        L6_1,
        
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding_tiers_and_levels
        /// </summary>
        [EnumMember(Value = "6.2")]
        L6_2
        
    }

}
