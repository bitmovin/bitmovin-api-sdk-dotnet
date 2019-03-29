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
    /// Id3TagPositionMode
    /// </summary>
    public enum Id3TagPositionMode
    {
        /// <summary>
        /// TIME
        /// </summary>
        [EnumMember(Value = "TIME")]
        TIME,
        
        /// <summary>
        /// FRAME
        /// </summary>
        [EnumMember(Value = "FRAME")]
        FRAME
        
    }

}
