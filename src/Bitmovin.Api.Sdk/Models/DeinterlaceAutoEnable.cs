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
    /// DeinterlaceAutoEnable
    /// </summary>
    public enum DeinterlaceAutoEnable
    {
        /// <summary>
        /// The content will always be deinterlaced with the settings specified (mode, parity, frameSelectionMode)
        /// </summary>
        [EnumMember(Value = "ALWAYS_ON")]
        ALWAYS_ON,
        
        /// <summary>
        /// The deinterlace filter will only be applied when interlaced content is detected in the meta data of the input stream. Additionally the parity will be set using the meta data if the parity is set as &quot;AUTO&quot; or &quot;default&quot;. Otherwise it will use the specified parity.
        /// </summary>
        [EnumMember(Value = "META_DATA_BASED")]
        META_DATA_BASED,
        
        /// <summary>
        /// This option will test the meta data and analyse the content to detect interlaced frames. If meta data detects interlaced content the mode works same as &quot;META_DATA_BASED&quot;. If content analysis detects interlaced frames the deinterlace filter will be applied in frameSelectionMode &quot;ALL&quot;.
        /// </summary>
        [EnumMember(Value = "META_DATA_AND_CONTENT_BASED")]
        META_DATA_AND_CONTENT_BASED
        
    }

}
