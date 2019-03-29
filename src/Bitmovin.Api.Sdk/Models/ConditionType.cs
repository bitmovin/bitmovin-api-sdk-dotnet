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
    /// ConditionType
    /// </summary>
    public enum ConditionType
    {
        /// <summary>
        /// Type of the condition
        /// </summary>
        [EnumMember(Value = "CONDITION")]
        CONDITION,
        
        /// <summary>
        /// Type of the condition
        /// </summary>
        [EnumMember(Value = "AND")]
        AND,
        
        /// <summary>
        /// Type of the condition
        /// </summary>
        [EnumMember(Value = "OR")]
        OR
        
    }

}
