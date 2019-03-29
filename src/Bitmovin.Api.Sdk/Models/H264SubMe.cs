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
    /// H264SubMe
    /// </summary>
    public enum H264SubMe
    {
        /// <summary>
        /// fullpel only (not recommended)
        /// </summary>
        [EnumMember(Value = "FULLPEL")]
        FULLPEL,
        
        /// <summary>
        /// SAD mode decision, one qpel iteration
        /// </summary>
        [EnumMember(Value = "SAD")]
        SAD,
        
        /// <summary>
        /// SATD mode decision
        /// </summary>
        [EnumMember(Value = "SATD")]
        SATD,
        
        /// <summary>
        /// Progressively more qpel
        /// </summary>
        [EnumMember(Value = "QPEL3")]
        QPEL3,
        
        /// <summary>
        /// Progressively more qpel
        /// </summary>
        [EnumMember(Value = "QPEL4")]
        QPEL4,
        
        /// <summary>
        /// Progressively more qpel
        /// </summary>
        [EnumMember(Value = "QPEL5")]
        QPEL5,
        
        /// <summary>
        /// RD mode decision for I/P+frames
        /// </summary>
        [EnumMember(Value = "RD_IP")]
        RD_IP,
        
        /// <summary>
        /// RD mode decision for all frames
        /// </summary>
        [EnumMember(Value = "RD_ALL")]
        RD_ALL,
        
        /// <summary>
        /// RD refinement for I/P+frames
        /// </summary>
        [EnumMember(Value = "RD_REF_IP")]
        RD_REF_IP,
        
        /// <summary>
        /// RD refinement for all frames
        /// </summary>
        [EnumMember(Value = "RD_REF_ALL")]
        RD_REF_ALL
        
    }

}
