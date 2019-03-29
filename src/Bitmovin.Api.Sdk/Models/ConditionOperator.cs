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
    /// ConditionOperator
    /// </summary>
    public enum ConditionOperator
    {
        /// <summary>
        /// Equal
        /// </summary>
        [EnumMember(Value = "==")]
        EQUAL,
        
        /// <summary>
        /// Not equal
        /// </summary>
        [EnumMember(Value = "!=")]
        NOT_EQUAL,
        
        /// <summary>
        /// Less than or equal
        /// </summary>
        [EnumMember(Value = "<=")]
        LESS_THAN_OR_EQUAL,
        
        /// <summary>
        /// Less then
        /// </summary>
        [EnumMember(Value = "<")]
        LESS_THAN,
        
        /// <summary>
        /// Greater than
        /// </summary>
        [EnumMember(Value = ">")]
        GREATER_THAN,
        
        /// <summary>
        /// Greater than or equal
        /// </summary>
        [EnumMember(Value = ">=")]
        GREATER_THAN_OR_EQUAL
        
    }

}
