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
    /// PictureFieldParity
    /// </summary>
    public enum PictureFieldParity
    {
        /// <summary>
        /// Automatic detection of field parity
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,
        
        /// <summary>
        /// Top field is first field
        /// </summary>
        [EnumMember(Value = "TOP_FIELD_FIRST")]
        TOP_FIELD_FIRST,
        
        /// <summary>
        /// Bottom field is first field
        /// </summary>
        [EnumMember(Value = "BOTTOM_FIELD_FIRST")]
        BOTTOM_FIELD_FIRST
        
    }

}
