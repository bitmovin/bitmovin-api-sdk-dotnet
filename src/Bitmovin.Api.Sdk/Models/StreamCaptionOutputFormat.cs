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
    /// StreamCaptionOutputFormat
    /// </summary>
    public enum StreamCaptionOutputFormat
    {
        /// <summary>
        /// Convert SCC captions to WebVTT format
        /// </summary>
        [EnumMember(Value = "WEBVTT")]
        WEBVTT
        
    }

}
