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
    /// MediaType
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// VIDEO
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        VIDEO,
        
        /// <summary>
        /// AUDIO
        /// </summary>
        [EnumMember(Value = "AUDIO")]
        AUDIO
        
    }

}
