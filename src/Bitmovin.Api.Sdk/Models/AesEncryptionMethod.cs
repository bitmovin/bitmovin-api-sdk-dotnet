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
    /// AesEncryptionMethod
    /// </summary>
    public enum AesEncryptionMethod
    {
        /// <summary>
        /// Detailed encryption method
        /// </summary>
        [EnumMember(Value = "SAMPLE_AES")]
        SAMPLEAES,
        
        /// <summary>
        /// Detailed encryption method
        /// </summary>
        [EnumMember(Value = "AES_128")]
        AES128
        
    }

}
