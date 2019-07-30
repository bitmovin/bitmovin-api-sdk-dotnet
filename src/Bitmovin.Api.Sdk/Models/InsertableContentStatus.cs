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
    /// InsertableContentStatus
    /// </summary>
    public enum InsertableContentStatus
    {
        /// <summary>
        /// CREATED
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,
        
        /// <summary>
        /// DOWNLOADING
        /// </summary>
        [EnumMember(Value = "DOWNLOADING")]
        DOWNLOADING,
        
        /// <summary>
        /// READY
        /// </summary>
        [EnumMember(Value = "READY")]
        READY,
        
        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
        
    }

}
