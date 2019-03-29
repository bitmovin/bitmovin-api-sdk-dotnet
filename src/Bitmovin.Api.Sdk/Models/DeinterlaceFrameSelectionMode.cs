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
    /// DeinterlaceFrameSelectionMode
    /// </summary>
    public enum DeinterlaceFrameSelectionMode
    {
        /// <summary>
        /// Deinterlace all frames
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL,
        
        /// <summary>
        /// Only deinterlace frames marked as interlaced. This option is only supported for deinterlace modes &#39;FRAME&#39; and &#39;FRAME_NOSPATIAL&#39;
        /// </summary>
        [EnumMember(Value = "INTERLACED")]
        INTERLACED
        
    }

}
