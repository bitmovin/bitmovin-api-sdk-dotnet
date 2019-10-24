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
    /// DolbyVisionMetadataSource
    /// </summary>
    public enum DolbyVisionMetadataSource
    {
        /// <summary>
        /// Dolby Vision Metadata is provided with an external XML file specified by the inputStreamId attribute.
        /// </summary>
        [EnumMember(Value = "INPUT_STREAM")]
        INPUT_STREAM,
        
        /// <summary>
        /// Dolby Vision Metadata is embedded in the input video.
        /// </summary>
        [EnumMember(Value = "EMBEDDED")]
        EMBEDDED
        
    }

}
