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
    /// AdaptationSetRole
    /// </summary>
    public enum AdaptationSetRole
    {
        /// <summary>
        /// Media content component that is an alternative to a main media content component of the same media component type
        /// </summary>
        [EnumMember(Value = "ALTERNATE")]
        ALTERNATE,
        
        /// <summary>
        /// Caption
        /// </summary>
        [EnumMember(Value = "CAPTION")]
        CAPTION,
        
        /// <summary>
        /// Media content component with commentary (typically audio, e.g. director&#39;s commentary)
        /// </summary>
        [EnumMember(Value = "COMMENTARY")]
        COMMENTARY,
        
        /// <summary>
        /// Media content component which is presented in a different language from the original (e.g. dubbed audio, translated captions)
        /// </summary>
        [EnumMember(Value = "DUB")]
        DUB,
        
        /// <summary>
        /// Main media component which is intended for presentation if no other information is provided
        /// </summary>
        [EnumMember(Value = "MAIN")]
        MAIN,
        
        /// <summary>
        /// Subtitle
        /// </summary>
        [EnumMember(Value = "SUBTITLE")]
        SUBTITLE,
        
        /// <summary>
        /// Media content component that is supplementary to a media content component of a different media component type
        /// </summary>
        [EnumMember(Value = "SUPPLEMENTARY")]
        SUPPLEMENTARY
        
    }

}
