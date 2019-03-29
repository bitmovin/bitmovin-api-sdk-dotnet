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
    /// AwsCloudRegion
    /// </summary>
    public enum AwsCloudRegion
    {
        /// <summary>
        /// USEAST1
        /// </summary>
        [EnumMember(Value = "US_EAST_1")]
        USEAST1,
        
        /// <summary>
        /// USEAST2
        /// </summary>
        [EnumMember(Value = "US_EAST_2")]
        USEAST2,
        
        /// <summary>
        /// USWEST1
        /// </summary>
        [EnumMember(Value = "US_WEST_1")]
        USWEST1,
        
        /// <summary>
        /// USWEST2
        /// </summary>
        [EnumMember(Value = "US_WEST_2")]
        USWEST2,
        
        /// <summary>
        /// EUWEST1
        /// </summary>
        [EnumMember(Value = "EU_WEST_1")]
        EUWEST1,
        
        /// <summary>
        /// EUCENTRAL1
        /// </summary>
        [EnumMember(Value = "EU_CENTRAL_1")]
        EUCENTRAL1,
        
        /// <summary>
        /// APSOUTHEAST1
        /// </summary>
        [EnumMember(Value = "AP_SOUTHEAST_1")]
        APSOUTHEAST1,
        
        /// <summary>
        /// APSOUTHEAST2
        /// </summary>
        [EnumMember(Value = "AP_SOUTHEAST_2")]
        APSOUTHEAST2,
        
        /// <summary>
        /// APNORTHEAST1
        /// </summary>
        [EnumMember(Value = "AP_NORTHEAST_1")]
        APNORTHEAST1,
        
        /// <summary>
        /// APNORTHEAST2
        /// </summary>
        [EnumMember(Value = "AP_NORTHEAST_2")]
        APNORTHEAST2,
        
        /// <summary>
        /// APSOUTH1
        /// </summary>
        [EnumMember(Value = "AP_SOUTH_1")]
        APSOUTH1,
        
        /// <summary>
        /// SAEAST1
        /// </summary>
        [EnumMember(Value = "SA_EAST_1")]
        SAEAST1
        
    }

}
