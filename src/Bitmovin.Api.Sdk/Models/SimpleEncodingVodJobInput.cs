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
    /// SimpleEncodingVodJobInput
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(SimpleEncodingVodJobUrlInput), "URL")]
    [JsonSubtypes.KnownSubType(typeof(SimpleEncodingVodJobDirectFileUploadInput), "DIRECT_FILE_UPLOAD")]

    public class SimpleEncodingVodJobInput
    {
    }
}
