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
    /// Status
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// The process has been created, but not started yet
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,
        
        /// <summary>
        /// The process has been enqueued for execution and will start as soon as resources are available
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED,
        
        /// <summary>
        /// The process is being executed
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,
        
        /// <summary>
        /// The process was finished successfully. This is a final state
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED,
        
        /// <summary>
        /// The process has stopped due to an error. This is a final state
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
        
    }

}
