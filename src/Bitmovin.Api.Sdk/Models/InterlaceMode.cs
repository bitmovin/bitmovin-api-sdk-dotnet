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
    /// InterlaceMode
    /// </summary>
    public enum InterlaceMode
    {
        /// <summary>
        /// Use the top field from odd frames and bottom field from even frames
        /// </summary>
        [EnumMember(Value = "TOP")]
        TOP,
        
        /// <summary>
        /// Use the bottom field from odd frames and top field from even frames
        /// </summary>
        [EnumMember(Value = "BOTTOM")]
        BOTTOM,
        
        /// <summary>
        /// Drop all even frames
        /// </summary>
        [EnumMember(Value = "DROP_EVEN")]
        DROP_EVEN,
        
        /// <summary>
        /// Drop all odd frames
        /// </summary>
        [EnumMember(Value = "DROP_ODD")]
        DROP_ODD,
        
        /// <summary>
        /// Double the height of all frames by inserting alternating black lines
        /// </summary>
        [EnumMember(Value = "PAD")]
        PAD,
        
        /// <summary>
        /// Double the frame rate. Extra frames use the second field of the next frame, alternating with the first field of the previous frame
        /// </summary>
        [EnumMember(Value = "INTERLACE_X2")]
        INTERLACE_X2,
        
        /// <summary>
        /// Move odd frames into the upper field and even frames into the lower field
        /// </summary>
        [EnumMember(Value = "MERGE")]
        MERGE,
        
        /// <summary>
        /// Double the height of all frames by inserting the lines of the next frame as second field
        /// </summary>
        [EnumMember(Value = "MERGE_X2")]
        MERGE_X2
        
    }

}
