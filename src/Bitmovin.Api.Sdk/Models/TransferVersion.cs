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
    /// TransferVersion
    /// </summary>
    public enum TransferVersion
    {
        /// <summary>
        /// DEFAULT
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,
        
        /// <summary>
        /// POOL
        /// </summary>
        [EnumMember(Value = "POOL")]
        POOL
        
    }

}
