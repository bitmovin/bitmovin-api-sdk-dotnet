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
    /// WeightedPredictionPFrames
    /// </summary>
    public enum WeightedPredictionPFrames
    {
        /// <summary>
        /// Do not keep P-frame references
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Enable weighted references
        /// </summary>
        [EnumMember(Value = "SIMPLE")]
        SIMPLE,
        
        /// <summary>
        /// Enable weighted references and duplicates
        /// </summary>
        [EnumMember(Value = "SMART")]
        SMART
        
    }

}
