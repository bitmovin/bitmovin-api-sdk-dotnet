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
    /// ScheduledContentInsertionStatus
    /// </summary>
    public enum ScheduledContentInsertionStatus
    {
        /// <summary>
        /// CREATED
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,
        
        /// <summary>
        /// SCHEDULED
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED,
        
        /// <summary>
        /// TOBEDESCHEDULED
        /// </summary>
        [EnumMember(Value = "TO_BE_DESCHEDULED")]
        TOBEDESCHEDULED,
        
        /// <summary>
        /// DESCHEDULED
        /// </summary>
        [EnumMember(Value = "DESCHEDULED")]
        DESCHEDULED,
        
        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
        
    }

}
