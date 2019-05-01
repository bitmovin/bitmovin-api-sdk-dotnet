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
    /// DashRepresentationTypeMode
    /// </summary>
    public enum DashRepresentationTypeMode
    {
        /// <summary>
        /// Generates representations containing segment templates. This is the default.
        /// </summary>
        [EnumMember(Value = "TEMPLATE_REPRESENTATION")]
        TEMPLATE_REPRESENTATION,
        
        /// <summary>
        /// Generates segment templates in the adaption sets. The representations will not contain any segment templates anymore.
        /// </summary>
        [EnumMember(Value = "TEMPLATE_ADAPTATION_SET")]
        TEMPLATE_ADAPTATION_SET
        
    }

}
