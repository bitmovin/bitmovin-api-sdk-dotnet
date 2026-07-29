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
    /// Credits
    /// </summary>
    public class Credits
    {
        /// <summary>
        /// Persons
        /// </summary>
        [JsonProperty(PropertyName = "persons")]
        public List<Person> Persons { get; set; } = new List<Person>();

        /// <summary>
        /// Songs
        /// </summary>
        [JsonProperty(PropertyName = "songs")]
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
