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
    /// DolbyVisionTrackSampleEntryName
    /// </summary>
    public enum DolbyVisionTrackSampleEntryName
    {
        /// <summary>
        /// Sets the Dolby Vision track&#39;s sample entry name to &#x60;dvhe&#x60;. This is the default value
        /// </summary>
        [EnumMember(Value = "DVHE")]
        DVHE,
        
        /// <summary>
        /// Sets the Dolby Vision track&#39;s sample entry name to &#x60;dvh1&#x60;
        /// </summary>
        [EnumMember(Value = "DVH1")]
        DVH1
        
    }

}
