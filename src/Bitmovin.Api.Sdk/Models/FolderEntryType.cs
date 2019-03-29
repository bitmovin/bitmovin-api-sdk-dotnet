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
    /// FolderEntryType
    /// </summary>
    public enum FolderEntryType
    {
        /// <summary>
        /// FILE
        /// </summary>
        [EnumMember(Value = "FILE")]
        FILE,
        
        /// <summary>
        /// FOLDER
        /// </summary>
        [EnumMember(Value = "FOLDER")]
        FOLDER
        
    }

}
