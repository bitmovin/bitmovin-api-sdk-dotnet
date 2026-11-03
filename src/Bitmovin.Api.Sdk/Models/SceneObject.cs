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
    /// SceneObject
    /// </summary>
    public class SceneObject
    {
        /// <summary>
        /// Free-text description of the object in this scene.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Kind of object in free text rather than a fixed category list.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
    }
}
