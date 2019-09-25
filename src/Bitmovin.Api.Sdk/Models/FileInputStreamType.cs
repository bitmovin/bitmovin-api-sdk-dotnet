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
    /// FileInputStreamType
    /// </summary>
    public enum FileInputStreamType
    {
        /// <summary>
        /// Specifies that the Sidecar file conforms to the TTML standard
        /// </summary>
        [EnumMember(Value = "TTML")]
        TTML,
        
        /// <summary>
        /// Specifies that the Sidecar file conforms to the WEBVTT standard
        /// </summary>
        [EnumMember(Value = "WEBVTT")]
        WEBVTT
        
    }

}
