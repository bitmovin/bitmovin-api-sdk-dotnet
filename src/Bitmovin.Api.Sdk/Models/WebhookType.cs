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
    /// WebhookType
    /// </summary>
    public enum WebhookType
    {
        /// <summary>
        /// FINISHED
        /// </summary>
        [EnumMember(Value = "ENCODING_FINISHED")]
        FINISHED,
        
        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ENCODING_ERROR")]
        ERROR
        
    }

}
