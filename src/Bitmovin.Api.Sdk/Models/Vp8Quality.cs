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
    /// Vp8Quality
    /// </summary>
    public enum Vp8Quality
    {
        /// <summary>
        /// Determines quality for the price of speed.
        /// </summary>
        [EnumMember(Value = "REALTIME")]
        REALTIME,
        
        /// <summary>
        /// Determines quality for the price of speed.
        /// </summary>
        [EnumMember(Value = "GOOD")]
        GOOD,
        
        /// <summary>
        /// Determines quality for the price of speed.
        /// </summary>
        [EnumMember(Value = "BEST")]
        BEST
        
    }

}
