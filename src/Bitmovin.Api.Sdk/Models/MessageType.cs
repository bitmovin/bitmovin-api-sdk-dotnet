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
    /// MessageType
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,
        
        /// <summary>
        /// WARNING
        /// </summary>
        [EnumMember(Value = "WARNING")]
        WARNING,
        
        /// <summary>
        /// INFO
        /// </summary>
        [EnumMember(Value = "INFO")]
        INFO,
        
        /// <summary>
        /// DEBUG
        /// </summary>
        [EnumMember(Value = "DEBUG")]
        DEBUG,
        
        /// <summary>
        /// TRACE
        /// </summary>
        [EnumMember(Value = "TRACE")]
        TRACE
        
    }

}
