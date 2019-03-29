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
    /// AnalyticsOperator
    /// </summary>
    public enum AnalyticsOperator
    {
        /// <summary>
        /// EQ
        /// </summary>
        [EnumMember(Value = "EQ")]
        EQ,
        
        /// <summary>
        /// NE
        /// </summary>
        [EnumMember(Value = "NE")]
        NE,
        
        /// <summary>
        /// LT
        /// </summary>
        [EnumMember(Value = "LT")]
        LT,
        
        /// <summary>
        /// LTE
        /// </summary>
        [EnumMember(Value = "LTE")]
        LTE,
        
        /// <summary>
        /// GT
        /// </summary>
        [EnumMember(Value = "GT")]
        GT,
        
        /// <summary>
        /// GTE
        /// </summary>
        [EnumMember(Value = "GTE")]
        GTE,
        
        /// <summary>
        /// CONTAINS
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        CONTAINS,
        
        /// <summary>
        /// NOTCONTAINS
        /// </summary>
        [EnumMember(Value = "NOTCONTAINS")]
        NOTCONTAINS
        
    }

}
