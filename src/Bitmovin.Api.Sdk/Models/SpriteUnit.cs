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
    /// SpriteUnit
    /// </summary>
    public enum SpriteUnit
    {
        /// <summary>
        /// Unit of positions is in seconds
        /// </summary>
        [EnumMember(Value = "SECONDS")]
        SECONDS,
        
        /// <summary>
        /// Unit of positions is in percent
        /// </summary>
        [EnumMember(Value = "PERCENTS")]
        PERCENTS
        
    }

}
