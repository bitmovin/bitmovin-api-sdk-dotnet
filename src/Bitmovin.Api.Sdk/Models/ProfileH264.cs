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
    /// ProfileH264
    /// </summary>
    public enum ProfileH264
    {
        /// <summary>
        /// Baseline profile
        /// </summary>
        [EnumMember(Value = "BASELINE")]
        BASELINE,
        
        /// <summary>
        /// Main profile
        /// </summary>
        [EnumMember(Value = "MAIN")]
        MAIN,
        
        /// <summary>
        /// High profile
        /// </summary>
        [EnumMember(Value = "HIGH")]
        HIGH
        
    }

}
