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
    /// HeAacV2Signaling
    /// </summary>
    public enum HeAacV2Signaling
    {
        /// <summary>
        /// Choose signaling implicitly (explicit hierarchical by default, implicit if global header is disabled).
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,
        
        /// <summary>
        /// Implicit backwards compatible signaling.
        /// </summary>
        [EnumMember(Value = "IMPLICIT")]
        IMPLICIT,
        
        /// <summary>
        /// Explicit SBR, implicit PS signaling.
        /// </summary>
        [EnumMember(Value = "EXPLICIT_SBR")]
        EXPLICIT_SBR,
        
        /// <summary>
        /// Explicit hierarchical signaling.
        /// </summary>
        [EnumMember(Value = "EXPLICIT_HIERACHICAL")]
        EXPLICIT_HIERACHICAL
        
    }

}
