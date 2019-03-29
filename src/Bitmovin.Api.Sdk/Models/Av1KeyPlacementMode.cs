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
    /// Av1KeyPlacementMode
    /// </summary>
    public enum Av1KeyPlacementMode
    {
        /// <summary>
        /// Specifies whether keyframes should be placed at fixed intervals or the encoder may determine optimal placement automatically
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,
        
        /// <summary>
        /// Specifies whether keyframes should be placed at fixed intervals or the encoder may determine optimal placement automatically
        /// </summary>
        [EnumMember(Value = "FIXED")]
        FIXED,
        
        /// <summary>
        /// Specifies whether keyframes should be placed at fixed intervals or the encoder may determine optimal placement automatically
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED
        
    }

}
