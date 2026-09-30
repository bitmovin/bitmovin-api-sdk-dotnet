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
    /// The auto shutdown configuration to set on a running Live Encoding. Any auto shutdown configuration the encoding currently has is overwritten.  Every timer that is omitted or &#x60;null&#x60; is disarmed. An empty object disarms all timers, so always send the complete configuration the encoding should run with, including the values that should stay unchanged. 
    /// </summary>
    public class LiveAutoShutdownConfigurationUpdateRequest : LiveAutoShutdownConfiguration
    {
    }
}
