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
    /// The template request object can be either a string (YAML/JSON) or a generic object that includes all the fields.  Please note that when sending the request as an object, the order of the fields is important, as it determines the sequence in which the Encoding resources are created. 
    /// </summary>
    public class EncodingTemplateRequest
    {
    }
}
