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
    /// PlayReadyEncryptionMethod
    /// </summary>
    public enum PlayReadyEncryptionMethod
    {
        /// <summary>
        /// Encryption method
        /// </summary>
        [EnumMember(Value = "MPEG_CENC")]
        MPEGCENC,
        
        /// <summary>
        /// Encryption method
        /// </summary>
        [EnumMember(Value = "PIFF_CTR")]
        PIFFCTR
        
    }

}
