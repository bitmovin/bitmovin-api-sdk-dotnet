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
    /// LiveEncodingStatus
    /// </summary>
    public enum LiveEncodingStatus
    {
        /// <summary>
        /// CONNECTED
        /// </summary>
        [EnumMember(Value = "CONNECTED")]
        CONNECTED,
        
        /// <summary>
        /// DISCONNECTED
        /// </summary>
        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,
        
        /// <summary>
        /// WAITINGFORFIRSTCONNECT
        /// </summary>
        [EnumMember(Value = "WAITING_FOR_FIRST_CONNECT")]
        WAITINGFORFIRSTCONNECT,
        
        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,
        
        /// <summary>
        /// NOTAVAILABLE
        /// </summary>
        [EnumMember(Value = "NOT_AVAILABLE")]
        NOTAVAILABLE,
        
        /// <summary>
        /// FINISHED
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED
        
    }

}
