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
    /// StatisticsResolution
    /// </summary>
    public enum StatisticsResolution
    {
        /// <summary>
        /// SD
        /// </summary>
        [EnumMember(Value = "SD")]
        SD,
        
        /// <summary>
        /// HD
        /// </summary>
        [EnumMember(Value = "HD")]
        HD,
        
        /// <summary>
        /// UHD
        /// </summary>
        [EnumMember(Value = "UHD")]
        UHD
        
    }

}
