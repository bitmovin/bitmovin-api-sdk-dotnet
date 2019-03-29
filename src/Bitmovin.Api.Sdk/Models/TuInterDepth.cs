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
    /// TuInterDepth
    /// </summary>
    public enum TuInterDepth
    {
        /// <summary>
        /// Extra recursion depth for intra coded units
        /// </summary>
        [EnumMember(Value = "1")]
        D1,
        
        /// <summary>
        /// Extra recursion depth for intra coded units
        /// </summary>
        [EnumMember(Value = "2")]
        D2,
        
        /// <summary>
        /// Extra recursion depth for intra coded units
        /// </summary>
        [EnumMember(Value = "3")]
        D3,
        
        /// <summary>
        /// Extra recursion depth for intra coded units
        /// </summary>
        [EnumMember(Value = "4")]
        D4
        
    }

}
