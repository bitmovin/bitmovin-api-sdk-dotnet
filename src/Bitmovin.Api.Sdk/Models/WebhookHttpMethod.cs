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
    /// WebhookHttpMethod
    /// </summary>
    public enum WebhookHttpMethod
    {
        /// <summary>
        /// POST
        /// </summary>
        [EnumMember(Value = "POST")]
        POST,
        
        /// <summary>
        /// PUT
        /// </summary>
        [EnumMember(Value = "PUT")]
        PUT
        
    }

}
