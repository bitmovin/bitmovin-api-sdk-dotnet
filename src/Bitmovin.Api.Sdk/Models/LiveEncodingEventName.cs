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
    /// LiveEncodingEventName
    /// </summary>
    public enum LiveEncodingEventName
    {
        /// <summary>
        /// First connection of the ingest
        /// </summary>
        [EnumMember(Value = "FIRST_CONNECT")]
        FIRST_CONNECT,
        
        /// <summary>
        /// Ingest has disconnected
        /// </summary>
        [EnumMember(Value = "DISCONNECT")]
        DISCONNECT,
        
        /// <summary>
        /// Ingest has reconnected
        /// </summary>
        [EnumMember(Value = "RECONNECT")]
        RECONNECT,
        
        /// <summary>
        /// Audio and video are out of sync and resyncing occurred. Usually happens after a RECONNECT event.
        /// </summary>
        [EnumMember(Value = "RESYNCING")]
        RESYNCING,
        
        /// <summary>
        /// Ingest is connected but doesn&#39;t send any data
        /// </summary>
        [EnumMember(Value = "IDLE")]
        IDLE,
        
        /// <summary>
        /// Error occurred, please see the errorMessage for further details
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
        
    }

}
