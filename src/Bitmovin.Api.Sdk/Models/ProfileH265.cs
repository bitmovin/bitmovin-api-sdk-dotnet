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
    /// ProfileH265
    /// </summary>
    public enum ProfileH265
    {
        /// <summary>
        /// Main profile
        /// </summary>
        [EnumMember(Value = "main")]
        MAIN,
        
        /// <summary>
        /// Main 10 profile
        /// </summary>
        [EnumMember(Value = "main10")]
        MAIN10
        
    }

}
