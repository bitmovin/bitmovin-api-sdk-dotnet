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
    /// TaskState
    /// </summary>
    public enum TaskState
    {
        /// <summary>
        /// ENQUEUED
        /// </summary>
        [EnumMember(Value = "ENQUEUED")]
        ENQUEUED,
        
        /// <summary>
        /// ASSIGNED
        /// </summary>
        [EnumMember(Value = "ASSIGNED")]
        ASSIGNED,
        
        /// <summary>
        /// PREPARED
        /// </summary>
        [EnumMember(Value = "PREPARED")]
        PREPARED,
        
        /// <summary>
        /// INPROGRESS
        /// </summary>
        [EnumMember(Value = "INPROGRESS")]
        INPROGRESS,
        
        /// <summary>
        /// FINISHED
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED,
        
        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,
        
        /// <summary>
        /// DEQUEUED
        /// </summary>
        [EnumMember(Value = "DEQUEUED")]
        DEQUEUED
        
    }

}
