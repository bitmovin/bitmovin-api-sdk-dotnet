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
    /// PixelFormat
    /// </summary>
    public enum PixelFormat
    {
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV410P")]
        YUV410P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV411P")]
        YUV411P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV420P")]
        YUV420P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV422P")]
        YUV422P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV440P")]
        YUV440P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV444P")]
        YUV444P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUVJ411P")]
        YUVJ411P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUVJ420P")]
        YUVJ420P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUVJ422P")]
        YUVJ422P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUVJ440P")]
        YUVJ440P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUVJ444P")]
        YUVJ444P,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV420P10LE")]
        YUV420P10LE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV422P10LE")]
        YUV422P10LE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV440P10LE")]
        YUV440P10LE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV444P10LE")]
        YUV444P10LE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV420P12LE")]
        YUV420P12LE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV422P12LE")]
        YUV422P12LE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV440P12LE")]
        YUV440P12LE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV444P12LE")]
        YUV444P12LE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV420P10BE")]
        YUV420P10BE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV422P10BE")]
        YUV422P10BE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV440P10BE")]
        YUV440P10BE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV444P10BE")]
        YUV444P10BE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV420P12BE")]
        YUV420P12BE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV422P12BE")]
        YUV422P12BE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV440P12BE")]
        YUV440P12BE,
        
        /// <summary>
        /// The pixel format to be set
        /// </summary>
        [EnumMember(Value = "YUV444P12BE")]
        YUV444P12BE
        
    }

}
