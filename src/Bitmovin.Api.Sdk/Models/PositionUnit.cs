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
    /// PositionUnit
    /// </summary>
    public enum PositionUnit
    {
        /// <summary>
        /// PIXELS
        /// </summary>
        [EnumMember(Value = "PIXELS")]
        PIXELS,
        
        /// <summary>
        /// PERCENTS
        /// </summary>
        [EnumMember(Value = "PERCENTS")]
        PERCENTS
        
    }

}
