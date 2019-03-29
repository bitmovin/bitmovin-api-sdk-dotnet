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
    /// DashMuxingType
    /// </summary>
    public enum DashMuxingType
    {
        /// <summary>
        /// Generates a SegmentTemplate based representation
        /// </summary>
        [EnumMember(Value = "TEMPLATE")]
        TEMPLATE,
        
        /// <summary>
        /// Generates a SegmentList based representation
        /// </summary>
        [EnumMember(Value = "LIST")]
        LIST,
        
        /// <summary>
        /// Generates a SegmentTimeline based representation
        /// </summary>
        [EnumMember(Value = "TIMELINE")]
        TIMELINE
        
    }

}
