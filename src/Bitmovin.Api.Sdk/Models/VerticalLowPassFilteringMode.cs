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
    /// VerticalLowPassFilteringMode
    /// </summary>
    public enum VerticalLowPassFilteringMode
    {
        /// <summary>
        /// Do not use vertical low pass filtering
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Recommended for progressive sources. Reduces Moire patterning and twitter
        /// </summary>
        [EnumMember(Value = "LOW_PASS")]
        LOW_PASS,
        
        /// <summary>
        /// Retaining better detail and sharpness, but less reduction in twitter
        /// </summary>
        [EnumMember(Value = "COMPLEX")]
        COMPLEX
        
    }

}
