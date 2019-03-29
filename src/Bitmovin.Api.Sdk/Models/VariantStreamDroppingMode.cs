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
    /// VariantStreamDroppingMode
    /// </summary>
    public enum VariantStreamDroppingMode
    {
        /// <summary>
        /// Variant stream dropping mode.
        /// </summary>
        [EnumMember(Value = "STREAM")]
        STREAM,
        
        /// <summary>
        /// Variant stream dropping mode.
        /// </summary>
        [EnumMember(Value = "AUDIO")]
        AUDIO
        
    }

}
