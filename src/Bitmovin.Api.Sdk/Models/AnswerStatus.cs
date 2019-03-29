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
    /// AnswerStatus
    /// </summary>
    public enum AnswerStatus
    {
        /// <summary>
        /// SUCCESS
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS,
        
        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
        
    }

}
