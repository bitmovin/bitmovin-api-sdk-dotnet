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
    /// AnalyticsExportStatus
    /// </summary>
    public enum AnalyticsExportStatus
    {
        /// <summary>
        /// STARTED
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,
        
        /// <summary>
        /// FINISHED
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED,
        
        /// <summary>
        /// QUEUED
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED,
        
        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
        
    }

}
