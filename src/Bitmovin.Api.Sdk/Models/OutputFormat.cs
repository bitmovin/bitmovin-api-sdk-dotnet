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
    /// OutputFormat
    /// </summary>
    public enum OutputFormat
    {
        /// <summary>
        /// WEBVTT
        /// </summary>
        [EnumMember(Value = "WEBVTT")]
        WEBVTT,
        
        /// <summary>
        /// SRT
        /// </summary>
        [EnumMember(Value = "SRT")]
        SRT
        
    }

}
