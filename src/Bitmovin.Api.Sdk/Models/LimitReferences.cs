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
    /// LimitReferences
    /// </summary>
    public enum LimitReferences
    {
        /// <summary>
        /// Disables limiting references
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Will limit the references analyzed at the current depth based on the references used to code the 4 sub-blocks at the next depth.
        /// </summary>
        [EnumMember(Value = "DEPTH")]
        DEPTH,
        
        /// <summary>
        /// The rectangular and asymmetrical partitions will only use references selected by the 2Nx2N motion search.
        /// </summary>
        [EnumMember(Value = "CU")]
        CU,
        
        /// <summary>
        /// The 2Nx2N motion search at each depth will only use references from the split CUs and the rect/amp motion searches at that depth will only use the reference(s) selected by 2Nx2N.
        /// </summary>
        [EnumMember(Value = "DEPTH_AND_CU")]
        DEPTH_AND_CU
        
    }

}
