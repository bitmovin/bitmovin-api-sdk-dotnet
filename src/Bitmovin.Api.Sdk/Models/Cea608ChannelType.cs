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
    /// Cea608ChannelType
    /// </summary>
    public enum Cea608ChannelType
    {
        /// <summary>
        /// Subtitle channel track
        /// </summary>
        [EnumMember(Value = "CC1")]
        CC1,
        
        /// <summary>
        /// Subtitle channel track
        /// </summary>
        [EnumMember(Value = "CC3")]
        CC3
        
    }

}
