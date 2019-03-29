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
    /// QuantizationGroupSize
    /// </summary>
    public enum QuantizationGroupSize
    {
        /// <summary>
        /// 8x8
        /// </summary>
        [EnumMember(Value = "QGS_8x8")]
        QGS_8x8,
        
        /// <summary>
        /// 16x16
        /// </summary>
        [EnumMember(Value = "QGS_16x16")]
        QGS_16x16,
        
        /// <summary>
        /// 32x32
        /// </summary>
        [EnumMember(Value = "QGS_32x32")]
        QGS_32x32,
        
        /// <summary>
        /// 64x64
        /// </summary>
        [EnumMember(Value = "QGS_64x64")]
        QGS_64x64
        
    }

}
