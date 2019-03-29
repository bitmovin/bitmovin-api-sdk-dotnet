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
    /// EncryptionType
    /// </summary>
    public enum EncryptionType
    {
        /// <summary>
        /// AES
        /// </summary>
        [EnumMember(Value = "AES")]
        AES,
        
        /// <summary>
        /// DESede
        /// </summary>
        [EnumMember(Value = "DESede")]
        DESede,
        
        /// <summary>
        /// Blowfish
        /// </summary>
        [EnumMember(Value = "Blowfish")]
        Blowfish,
        
        /// <summary>
        /// RSA
        /// </summary>
        [EnumMember(Value = "RSA")]
        RSA
        
    }

}
