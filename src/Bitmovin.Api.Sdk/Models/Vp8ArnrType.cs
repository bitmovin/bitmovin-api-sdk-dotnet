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
    /// Vp8ArnrType
    /// </summary>
    public enum Vp8ArnrType
    {
        /// <summary>
        /// altref noise reduction filter type
        /// </summary>
        [EnumMember(Value = "BACKWARD")]
        BACKWARD,
        
        /// <summary>
        /// altref noise reduction filter type
        /// </summary>
        [EnumMember(Value = "FORWARD")]
        FORWARD,
        
        /// <summary>
        /// altref noise reduction filter type
        /// </summary>
        [EnumMember(Value = "CENTERED")]
        CENTERED
        
    }

}
