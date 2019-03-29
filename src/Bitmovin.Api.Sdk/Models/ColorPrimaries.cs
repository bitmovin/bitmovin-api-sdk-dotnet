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
    /// ColorPrimaries
    /// </summary>
    public enum ColorPrimaries
    {
        /// <summary>
        /// UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,
        
        /// <summary>
        /// BT709
        /// </summary>
        [EnumMember(Value = "BT709")]
        BT709,
        
        /// <summary>
        /// BT470M
        /// </summary>
        [EnumMember(Value = "BT470M")]
        BT470M,
        
        /// <summary>
        /// BT470BG
        /// </summary>
        [EnumMember(Value = "BT470BG")]
        BT470BG,
        
        /// <summary>
        /// SMPTE170M
        /// </summary>
        [EnumMember(Value = "SMPTE170M")]
        SMPTE170M,
        
        /// <summary>
        /// SMPTE240M
        /// </summary>
        [EnumMember(Value = "SMPTE240M")]
        SMPTE240M,
        
        /// <summary>
        /// FILM
        /// </summary>
        [EnumMember(Value = "FILM")]
        FILM,
        
        /// <summary>
        /// BT2020
        /// </summary>
        [EnumMember(Value = "BT2020")]
        BT2020,
        
        /// <summary>
        /// SMPTE428
        /// </summary>
        [EnumMember(Value = "SMPTE428")]
        SMPTE428,
        
        /// <summary>
        /// SMPTEST428_1
        /// </summary>
        [EnumMember(Value = "SMPTEST428_1")]
        SMPTEST428_1,
        
        /// <summary>
        /// SMPTE431
        /// </summary>
        [EnumMember(Value = "SMPTE431")]
        SMPTE431,
        
        /// <summary>
        /// SMPTE432
        /// </summary>
        [EnumMember(Value = "SMPTE432")]
        SMPTE432,
        
        /// <summary>
        /// JEDEC_P22
        /// </summary>
        [EnumMember(Value = "JEDEC_P22")]
        JEDEC_P22
        
    }

}
