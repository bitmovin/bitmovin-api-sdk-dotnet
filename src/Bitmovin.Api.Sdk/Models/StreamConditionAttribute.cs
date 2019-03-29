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
    /// StreamConditionAttribute
    /// </summary>
    public enum StreamConditionAttribute
    {
        /// <summary>
        /// Type of the stream available values: VIDEO, AUDIO
        /// </summary>
        [EnumMember(Value = "MEDIA_TYPE")]
        MEDIA_TYPE,
        
        /// <summary>
        /// Specific stream id of encoding
        /// </summary>
        [EnumMember(Value = "STREAM_ID")]
        STREAM_ID,
        
        /// <summary>
        /// Average bits read
        /// </summary>
        [EnumMember(Value = "BITS_READ_AVG")]
        BITS_READ_AVG,
        
        /// <summary>
        /// Minimum bits read
        /// </summary>
        [EnumMember(Value = "BITS_READ_MIN")]
        BITS_READ_MIN,
        
        /// <summary>
        /// Maximum bits read
        /// </summary>
        [EnumMember(Value = "BITS_READ_MAX")]
        BITS_READ_MAX,
        
        /// <summary>
        /// Average samples read
        /// </summary>
        [EnumMember(Value = "SAMPLES_READ_AVG")]
        SAMPLES_READ_AVG,
        
        /// <summary>
        /// Minimum samples read
        /// </summary>
        [EnumMember(Value = "SAMPLES_READ_MIN")]
        SAMPLES_READ_MIN,
        
        /// <summary>
        /// Maximum samples read
        /// </summary>
        [EnumMember(Value = "SAMPLES_READ_MAX")]
        SAMPLES_READ_MAX,
        
        /// <summary>
        /// Specify a width
        /// </summary>
        [EnumMember(Value = "WIDTH")]
        WIDTH,
        
        /// <summary>
        /// Specify a height
        /// </summary>
        [EnumMember(Value = "HEIGHT")]
        HEIGHT,
        
        /// <summary>
        /// Specify a codec
        /// </summary>
        [EnumMember(Value = "CODEC")]
        CODEC
        
    }

}
