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
    /// MvPredictionMode
    /// </summary>
    public enum MvPredictionMode
    {
        /// <summary>
        /// Sets the Motion Vector Prediction Mode.
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Sets the Motion Vector Prediction Mode.
        /// </summary>
        [EnumMember(Value = "SPATIAL")]
        SPATIAL,
        
        /// <summary>
        /// Sets the Motion Vector Prediction Mode.
        /// </summary>
        [EnumMember(Value = "TEMPORAL")]
        TEMPORAL,
        
        /// <summary>
        /// Sets the Motion Vector Prediction Mode.
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO
        
    }

}
